using System;
using System.Collections.Generic;
using System.Linq;

namespace Bottle
{
    /// <summary>
    /// Параметры бутылки.
    /// </summary>
    public class BottleParameters
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="baseDiameter">Диаметр основания.</param>
        /// <param name="baseLength">Длина основания.</param>
        /// <param name="bottleneckDiameter">Диаметр горлышка.</param>
        /// <param name="bottleneckLength">Длина горлышка.</param>
        /// <param name="lengthFullBottle">Длина бутылки.</param>
        public BottleParameters(double baseDiameter, double baseLength, double bottleneckDiameter,
            double bottleneckLength, double lengthFullBottle)
        {
            var errors = Validate(baseDiameter, baseLength, bottleneckDiameter, bottleneckLength, lengthFullBottle);

            if (errors.Any())
                throw new ArgumentException(GetUnitedErrorMessage(errors));

            BaseDiameter = baseDiameter;
            BaseLength = baseLength;
            BottleneckDiameter = bottleneckDiameter;
            BottleneckLength = bottleneckLength;
            LengthFullBottle = lengthFullBottle;
        }

        /// <summary>
        /// Диаметр основания.
        /// </summary>
        public double BaseDiameter { get; }

        /// <summary>
        /// Длина основания.
        /// </summary>
        public double BaseLength { get; }

        /// <summary>
        /// Диаметр горлышка.
        /// </summary>
        public double BottleneckDiameter { get; }

        /// <summary>
        /// Длина горлышка.
        /// </summary>
        public double BottleneckLength { get; }

        /// <summary>
        /// Длина всей бутылки.
        /// </summary>
        public double LengthFullBottle { get; }

        /// <summary>
        /// Проверяет полученные параметры на корректность.
        /// </summary>
        /// <param name="baseDiameter">Диаметр основания.</param>
        /// <param name="baseLength">Длина основания.</param>
        /// <param name="bottleneckDiameter">Диаметр горлышка.</param>
        /// <param name="bottleneckLength">Длина горлышка.</param>
        /// <param name="lengthFullBottle">Длина бутылки.</param>
        /// <returns>Сообщения об ошибках.</returns>
        private static List<string> Validate(double baseDiameter, double baseLength, double bottleneckDiameter,
            double bottleneckLength, double lengthFullBottle)
        {
            var errors = new List<string>();

            const double minLengthFullBottle = 100;
            const double maxLengthFullBottle = 254;

            const double minBaseLength = 2 * minLengthFullBottle / 3;
            var maxBaseLength = 2 * lengthFullBottle / 3;

            const double minBottleneckLength = minLengthFullBottle / 5;
            var maxBottleneckLength = lengthFullBottle / 5;

            const double minBaseDiameter = 25;
            const double maxBaseDiameter = 65;

            const double minBottleneckDiameter = 10;
            var maxBottleneckDiameter = baseDiameter < 26 ? baseDiameter : 26;

            if (lengthFullBottle < minLengthFullBottle)
                errors.Add($"минимальная длина бутылки = {minLengthFullBottle} мм");
            if (lengthFullBottle > maxLengthFullBottle)
                errors.Add($"максимальная длина бутылки = {maxLengthFullBottle} мм");

            if (baseLength < minBaseLength)
                errors.Add($"минимальная длина основания = {minBaseLength} мм");
            if (baseLength > maxBaseLength)
                errors.Add($"максимальная длина основания = {maxBaseLength} мм");

            if (bottleneckLength < minBottleneckLength)
                errors.Add($"минимальная длина горлышка = {minBottleneckLength} мм");
            if (bottleneckLength > maxBottleneckLength)
                errors.Add($"максимальная длина горлышка = {maxBottleneckLength} мм");

            if (baseDiameter < minBaseDiameter)
                errors.Add($"минимальный диаметр основания = {minBaseDiameter} мм");
            if (baseDiameter > maxBaseDiameter)
                errors.Add($"максимальный диаметр основания = {maxBaseDiameter} мм");

            if (bottleneckDiameter < minBottleneckDiameter)
                errors.Add($"минимальный диаметр горлышка = {minBottleneckDiameter} мм");
            if (bottleneckDiameter > maxBottleneckDiameter)
                errors.Add($"максимальный диаметр горлышка = {maxBottleneckDiameter} мм");

            return errors;
        }

        /// <summary>
        /// Получает обеще сообщение об ошибке из списка ошибок.
        /// </summary>
        /// <param name="errorMessages">Сообщения об ошибках.</param>
        /// <returns>Общее сообщение.</returns>
        private static string GetUnitedErrorMessage(IEnumerable<string> errorMessages)
        {
            var result = "Параметры некорректны:\n\n";

            foreach (var errorMessage in errorMessages)
                result += errorMessage + ";\n\n";

            result = result.Substring(0, result.Length - 3);

            result += '.';

            return result;
        }
    }
}