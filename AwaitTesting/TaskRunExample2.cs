//MyClass myClass = new();

//myClass.MyMethod();

//public class MyClass
//{
//    public void MyMethod()
//    {
//        Console.WriteLine("Id Main: " + Environment.CurrentManagedThreadId);

//        /*
//         * Why does the following code not count correctly?
//         */




//        for (int i = 0; i < 10; i++)
//        {
//            Task.Run(() =>
//            {
//                Console.WriteLine("Id Run " + i + ": " + Thread.CurrentThread.ManagedThreadId);
//            });
//        }

//        Console.ReadLine(); 
        
//        //for (int i = 0; i < 100; i++)
//        //{
//        //    var t = new Thread(() =>
//        //    {
//        //        Console.WriteLine("Id Thread " + i + ": " + Thread.CurrentThread.ManagedThreadId);
//        //    });
//        //    t.Start();
//        //}

//        //Console.ReadLine();
//    }
//}