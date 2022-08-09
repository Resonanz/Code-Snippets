const int numAwaits = 4;
const int numAwaitCounts = 200000000;

MyClass[] myClass = new MyClass[numAwaits];

for (int i = 0; i < numAwaits; i++)
{
    myClass[i] = new MyClass();
    _ = myClass[i].MyMethod(i, numAwaitCounts);
}

Console.WriteLine("Started all tasks.");

Console.ReadLine();



public class MyClass
{
    public async Task MyMethod(int i, int numCounts)
    {
        Console.WriteLine("Starting instance: " + i);

        await WasteSomeTime(numCounts);
    }

    public Task WasteSomeTime(int numCounts)
    {
        int accumulator = 0;

        Console.WriteLine("Awaiting thread: " + Environment.CurrentManagedThreadId);

        for (int i = 0; i < numCounts; i++)
        {
            accumulator += i;
        }

        Console.WriteLine("Finished computation inside thread: " + Environment.CurrentManagedThreadId);
        return Task.CompletedTask;
    }
}






public class MyClass2
{
    /*
     *  We would use task<int> if returning an int
     */
    public async Task MyMethod(int i, int numCounts)
    {
        Console.WriteLine("Starting instance: " + i);
        //await Task.Run(() => _ = WasteSomeTime(numCounts));
        //await WasteSomeTime(numCounts);

        await Task.Run(() =>
        {
            int accumulator = 0;

            Console.WriteLine("Awaiting thread " + Environment.CurrentManagedThreadId);

            for (int i = 0; i < numCounts; i++)
            {
                accumulator += i;
            }

            Console.WriteLine("Finished computation inside thread " + Environment.CurrentManagedThreadId);
        });
    }







    public async Task WasteSomeTime(int count)
    {
        int accumulator = 0;

        Console.WriteLine("Awaiting thread: " + Environment.CurrentManagedThreadId);

        for (int i = 0; i < count; i++)
        {
            accumulator += i;
        }

        Console.WriteLine("Finished computation inside thread: " + Environment.CurrentManagedThreadId);

        //return accumulator;
    }
}