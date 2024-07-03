await Await10Seconds();
await Await5Seconds();
await Await1Second();

await Task.WhenAll(Await10Seconds(), Await5Seconds(), Await1Second());

var positionExecuted = Task.WaitAny(Await10Seconds(), Await5Seconds(), Await1Second());
Console.WriteLine(positionExecuted);


async Task Await10Seconds()
{
    Console.WriteLine($"start: {nameof(Await10Seconds)}");
    await Task.Delay(TimeSpan.FromSeconds(10));
    Console.WriteLine($"finish: {nameof(Await10Seconds)}");
}

async Task Await5Seconds()
{
    Console.WriteLine($"start: {nameof(Await5Seconds)}");
    await Task.Delay(TimeSpan.FromSeconds(5));
    Console.WriteLine($"finish: {nameof(Await5Seconds)}");
}

async Task Await1Second()
{
    Console.WriteLine($"start: {nameof(Await1Second)}");
    await Task.Delay(TimeSpan.FromSeconds(1));
    Console.WriteLine($"finish: {nameof(Await1Second)}");
}