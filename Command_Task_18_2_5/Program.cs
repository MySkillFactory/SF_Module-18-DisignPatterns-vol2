using Command_Task_18_2_5;
// Задание 18.2.5

Pult pult = new Pult();
Gate gate = new Gate();

pult.SetAction(new GateOpenAction(gate));
pult.OpenButton();
pult.CloseButton();

Console.ReadKey();

