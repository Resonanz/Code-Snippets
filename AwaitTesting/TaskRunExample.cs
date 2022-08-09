//using System.Diagnostics.Metrics;

//const int numInstances = 3;

//MyClass[] myClass = new MyClass[numInstances];

//for (int i = 0; i < numInstances; i++)
//{
//    myClass[i] = new MyClass();
//    _ = myClass[i].MyMethod(i);
//}

//Console.ReadLine();

//public class MyClass
//{
//    public async Task MyMethod(int i)
//    {
//        Console.Write("Awaiting" + i + "... ");
//        int sum = await Counter(5);
//        Console.WriteLine(sum);  // Task.Delay(3000);
//        Console.WriteLine("Done" + i);
//    }

//    public async Task<int> Counter(int count)
//    {
//        int counter = 0;

//        await Task.Run(MyMethod);

//        await Task.Run(() =>
//        {
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("A = " + Thread.CurrentThread.ManagedThreadId);
//                counter += i;
//            }
//        });

//        return count;
//    }

//    public int MyMethod()
//    {
//        Console.WriteLine("B = " + Thread.CurrentThread.ManagedThreadId);
//        return 0;
//    }

//    public int WasteSomeTime(int count)
//    {
//        int accumulator = 0;

//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine("A = " + Thread.CurrentThread.ManagedThreadId);
//            accumulator += i;
//        }
//        return 0;
//    }
//}