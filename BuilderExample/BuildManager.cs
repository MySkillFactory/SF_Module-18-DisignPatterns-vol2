using System;
namespace BuilderExample
{
    /// <summary>
    /// Объект, инкапсулирующий процесс строительства
    /// </summary>
    public class BuildManager
	{
		IBuilder Builder;

		public BuildManager(IBuilder builder)
		{
			Builder = builder;
		}

		public void StartBuildingProcess()
		{
			Builder.FirstStage();
			Builder.SecondStage();
			Builder.ThirdStage();
		}
	}
}

