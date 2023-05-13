using System;
using System.Security.Cryptography;

namespace BuilderExample
{
    /// <summary>
    /// Абстрактный интерфейс строителя
    /// </summary>
    public interface IBuilder
	{
        void FirstStage();
        void SecondStage();
        void ThirdStage();
        Product GetBuildingResult();
    }
}

