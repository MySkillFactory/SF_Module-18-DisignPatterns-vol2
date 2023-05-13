using Builder_Task_18_1_1;

// Создаем автомобиль
Conveyor builder = new CarConveyor();
Construct(builder);

// Создаем мотоцикл
builder = new MotoConveyor();
Construct(builder);

//Создаем скутер
builder = new ScooterConveyor();
Construct(builder);

Console.ReadKey();

static void Construct(Conveyor builder)
{
    // Объект завода, который будет заниматься производством
    var carPlant = new CarPlant();
    carPlant.Construct(builder);
    builder.Product.Show();
}