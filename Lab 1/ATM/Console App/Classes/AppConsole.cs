using Class_Library;
using Class_Library.Utils;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_App.Classes
{
    public static class AppConsole
    {
        public static string GetClassListAsTable<T>(List<T> instances, bool shouldEnumerate = false)
        {
            if (instances == null || instances.Count == 0)
            {
                return "";
            }

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            // Extract property names as column headers
            var columns = properties
                .Where(property => property.CanRead && !property.GetMethod.IsStatic)
                .Select(property => TextFormatter.SplitCamelCase(property.Name))
                .ToList();

            var rows = new List<List<String>>();

            // Add columns with extracted headers
            //var table = new ConsoleTable(columnHeaders.ToArray());


            // Add data rows
            for (int i = 0; i < instances.Count; i++)
            {
                var rowData = properties
                    .Where(property => property.CanRead && !property.GetMethod.IsStatic)
                    .Select(property =>
                    {
                        var propertyValue = property.GetValue(instances[i]);

                        return propertyValue == null ? "" : propertyValue.ToString();
                    })
                    .ToList();

                rows.Add(rowData);
            }

            ConsoleTable table;

            if (shouldEnumerate)
            {
                table = GetEnumeratedTable(columns, rows);
            }
            else
            {
                table = new ConsoleTable(columns.ToArray());

                rows.ForEach(row => table.AddRow(row.ToArray()));
            }

            table.Options.NumberAlignment = Alignment.Right;

            return table.ToString();
        }

        public static ConsoleTable GetEnumeratedTable(
            IEnumerable<String> headers,
            IEnumerable<IEnumerable<String>> rows
        )
        {
            var columns = headers.ToList();
            columns.Insert(0, "#");

            var table = new ConsoleTable(columns.ToArray());

            for (int i = 0; i < rows.Count(); i++)
            {
                var row = rows.ElementAt(i).ToList();
                row.Insert(0, (i + 1).ToString());

                table.AddRow(row.ToArray());
            }

            table.Options.EnableCount = false;
            table.Options.NumberAlignment = Alignment.Right;

            return table;
        }

        public static string ReadValidatedValue(
            Predicate<string>? ValidateValue,
            Action? OnValidationFailed
        )
        {
            string result;

            while (true)
            {
                Write("--> ");
                var input = ReadLine() ?? "";

                if (ValidateValue != null && ValidateValue(input))
                {
                    result = input;
                    break;
                }

                OnValidationFailed?.Invoke();
            }

            return result;
        }

        public static string ReadValidatedValueWithLabel(
            string label,
            Predicate<string>? ValidateValue,
            Action? OnValidationFailed
        )
        {
            WriteLine(label);

            var validatedValue = ReadValidatedValue(ValidateValue, OnValidationFailed);

            return validatedValue;
        }

        public static T ReadEnumValue<T>()
            where T : Enum
        {
            var enumNames = Enum.GetNames(typeof(T)).Select(TextFormatter.SplitCamelCase).ToList();

            var enumDisplayName = TextFormatter.SplitCamelCase(typeof(T).Name);

            var enumTable = GetEnumeratedTable(
                new List<String>() { enumDisplayName },
                enumNames.Select(enumName => new List<String>() { FormatRow(enumName) })
            );
            enumTable.Options.EnableCount = false;

            var enumNum = int.Parse(
                ReadValidatedValueWithLabel(
                    $"Select {enumDisplayName.ToLower()}: \n\n{enumTable}",
                    enumNum => int.Parse(enumNum) > 0 && int.Parse(enumNum) <= enumNames.Count,
                    () => WriteLine("Invalid index. Please try again.")
                )
            );

            var enumValueAsString = UnformatRow(enumNames[enumNum - 1]);

            var enumType = typeof(T);

            T enumValue = (T)Enum.Parse(enumType, enumValueAsString);

            return enumValue;
        }

        public static string FormatHeader(string header)
        {
            return TextFormatter.SplitCamelCase(header).ToLower();
        }

        public static string FormatRow(string row)
        {
            return TextFormatter.SplitCamelCase(row);
        }

        public static string UnformatRow(string row)
        {
            return TextFormatter.UnsplitCamelCase(row);
        }
    }
}
