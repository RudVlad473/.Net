using Console_App.Classes;
using static System.Console;
using ConsoleTables;
using Class_Library;

const int MAX_ATTEMPTS = 3;

var mockBank = MockBank.GetMockBank();

var appState = AppState.Instance;

appState.Initialize(mockBank, new ConsoleNotificationSender().SendNotification);

appState.Notification.AddNotify(new EmailNotificationSender("rudenkovladimir2003@gmail.com").SendNotification);

// select atm
WriteLine(
    "Hello! Select ATM machine from the list (selection is done via number buttons on keyboard):"
);

WriteLine(AppConsole.GetClassListAsTable(appState.Atms, true));

var atmNum = int.Parse(
    AppConsole.ReadValidatedValue(
        value =>
        {
            int atmMachineNum;

            bool validAtmMachineNum =
                int.TryParse(value, out atmMachineNum)
                && atmMachineNum > 0
                && atmMachineNum <= appState.Atms.Count;

            return validAtmMachineNum;
        },
        (value) => WriteLine("Invalid ATM machine number. Please try again.")
    )
);

appState.SelectAtm(appState.Atms[atmNum - 1].Id);

WriteLine(AppConsole.GetClassListAsTable(new List<ATM> { appState.SelectedAtm }));

// select account
for (int attempts = 0; attempts < MAX_ATTEMPTS; attempts++)
{
    var cardNumber = AppConsole.ReadValidatedValueWithLabel(
        "Input card number (format: 0000 0000 0000 0000):",
        Credentials.ValidateCardNumber,
        (value) => WriteLine("Invalid card number or format. Please try again.")
    );

    var pin = AppConsole.ReadValidatedValueWithLabel(
        "Input pin (format: 0000):",
        Credentials.ValidatePin,
        (value) => WriteLine("Invalid pin or format. Please try again. ")
    );

    try
    {
        appState.Authenticate(new Credentials(cardNumber, pin));

        break;
    }
    catch (Exception e)
    {
        attempts++;

        WriteLine(e.Message);

        if (attempts == MAX_ATTEMPTS - 1)
        {
            appState.Notification.SendNotification(
                new Message("Failure", "You have exceeded the maximum number of attempts.")
            );
            Environment.Exit(0);
        }

        WriteLine($"Attempts left: {MAX_ATTEMPTS - attempts}");
    }
}

// select operation

while (true)
{
    WriteLine();

    var operationType = AppConsole.ReadEnumValue<OperationType>();

    bool shouldExit = false;

    switch (operationType)
    {
        case OperationType.Deposit:
            var depositAmount = decimal.Parse(
                AppConsole.ReadValidatedValueWithLabel(
                    "Input amount to deposit:",
                    value => decimal.Parse(value) > 0,
                    (value) => WriteLine("Invalid amount. Please try again.")
                )
            );

            try
            {
                appState.Deposit(depositAmount);
            }
            catch (Exception e)
            {
                appState.Notification.SendNotification(new Message("Failure", e.Message));

                continue;
            }

            break;
        case OperationType.Withdraw:
            var withdrawAmount = decimal.Parse(
                AppConsole.ReadValidatedValueWithLabel(
                    "Input amount to withdraw:",
                    value => decimal.TryParse(value, out decimal _),
                    (value) => WriteLine("Invalid amount. Please try again.")
                )
            );

            try
            {
                appState.Withdraw(withdrawAmount);
            }
            catch (Exception e)
            {
                appState.Notification.SendNotification(new Message("Failure", e.Message));

                continue;
            }

            break;
        case OperationType.Transaction:
            var transactionCardNumber = AppConsole.ReadValidatedValueWithLabel(
                "Input card number:",
                Credentials.ValidateCardNumber,
                (value) => WriteLine("Invalid card number. Please try again.")
            );

            var amountToTransfer = decimal.Parse(
                AppConsole.ReadValidatedValueWithLabel(
                    "Input amount to transfer:",
                    value => decimal.Parse(value) > 0,
                    (value) => WriteLine("Invalid amount. Please try again.")
                )
            );

            try
            {
                appState.Transaction(transactionCardNumber, amountToTransfer);
            }
            catch (Exception e)
            {
                appState.Notification.SendNotification(new Message("Failure", e.Message));

                continue;
            }

            break;
        case OperationType.NearestAtms:
            var nearestAtms = appState.GetNearestAtms();

            if (nearestAtms == null || nearestAtms.Count == 0)
            {
                appState.Notification.SendNotification(new Message(null, "No nearest ATMs found."));

                continue;
            }

            appState.Notification.SendNotification(
                new Message("Nearest ATMs", AppConsole.GetClassListAsTable(nearestAtms).ToString())
            );

            break;
        case OperationType.Exit:
            shouldExit = true;

            appState.Exit();

            break;
        case OperationType.Balance:
            appState.Balance();

            break;
        case OperationType.OperationsHistory:
            var period = AppConsole.ReadEnumValue<Period>();

            List<Operation> operations;

            switch (period)
            {
                case Period.Today:
                    operations = appState.Operations
                        .Where(operation => operation.Timestamp.Date == DateTime.Now.Date)
                        .ToList();

                    break;
                case Period.ThisWeek:
                    operations = appState.Operations
                        .Where(
                            operation => operation.Timestamp.Date >= DateTime.Now.Date.AddDays(-7)
                        )
                        .ToList();

                    break;
                case Period.ThisMonth:
                    operations = appState.Operations
                        .Where(
                            operation =>
                                operation.Timestamp.Date >= DateTime.Now.Date.AddMonths(-1).Date
                        )
                        .ToList();

                    break;
                default:
                    operations = appState.Operations;

                    break;
            }

            appState.Notification.SendNotification(
                new Message(
                    $"{TextFormatter.SplitCamelCase(period.ToString())}'s operations",
                    AppConsole.GetClassListAsTable(operations)?.ToMinimalString()
                        ?? "No operations found."
                )
            );

            break;
        default:
            WriteLine("Option is not available.");

            break;
    }

    if (shouldExit)
    {
        break;
    }
}
