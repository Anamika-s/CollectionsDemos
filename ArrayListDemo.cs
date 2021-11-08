// using System;
// using System.Collections;
// class Program
//     {
        
//          static void Display(ArrayList list)
//         {
//             foreach(var x in list) // unboxing happens here 
//                 Console.WriteLine(x);
//         }
//         static void Main()
//         {
//            ArrayList list = new ArrayList(); //  No Size is mentioned
//            // Boxing 
//            list.Add(1); // It converts value typ e to object type
//            list.Add(2);
//            list.Add(3);
//            list.Add("Deepak");
//            list.Add(12.90);
//            list.Add(true);





//            Display(list);
//         //    for(int i=0;i<list.Count;i++)
//         //    Console.WriteLine(list[i]);
//            list.Insert(1,100);
//            Console.WriteLine("After Inserting 100");
//            Display(list);
//            list.RemoveAt(0);
//             Console.WriteLine("After Removing Element from position 0");
//         Display(list);
//         //     for(int i=0;i<list.Count;i++)
//         //    Console.WriteLine(list[i]);
//         Console.WriteLine("After Removing 100");
       
//            list.Remove(100);
//            Display(list);
//         Console.WriteLine("Enter Element to delete ");
//         int x  = Convert.ToByte(Console.ReadLine());
//         for(int i = 0;i< list.Count; i++)
//         {
//           if((int)list[i] == x)
//          {
//          list.Remove(list[i]);
//          }
//          }
//         Display(list);

           

//         }
//     }

