using System;
using static System.Console;
namespace csharp7
{
    static class CeShi
    {
        static void Main()
        {
            
            Hamster hamster = new Hamster();
            hamster.TeethLength = 20;//不知道多少牙齿
            Bunny bunny = new Bunny();
            bunny.EarLength = 10;//嗯耳朵很长

            #region 1.OutVars
            //之前这么用
            OutVars.Old();
            //C#7 这么用
            OutVars.New();
            #endregion

            #region 2.IsExpression


            ////之前这么用
            //IsExpression.Old(hamster);

            ////现在这么用
            //IsExpression.New(hamster);

            #endregion

            #region 3.Switch
            ////之前
            //Switch.Old(hamster);
            ////现在新语法
            //Switch.New(hamster);
            #endregion

            #region 4. Tuples
            //Tuples.Foo();
            #endregion

            #region 5. Deconstructors

            //Deconstructors.Foo();

            #endregion

            #region 6. LocalFunctions
            int key1 = 5;
            int timeout = 1;
            ////之前
            //LocalFunctions.GetAsyncOld(5, 1);
            ////现在
            //LocalFunctions.GetAsyncNew(5, 1);

            #endregion

            #region 7. RefReturns
            //int[] array = { 1, 15, -39, 0, 7, 14, -12 };
            //ref int slot = ref RefReturns.Find(7, array);
            //slot = 9; // 用9代替7
            //WriteLine(array[4]); // 打印 9
            #endregion
        }
    }
}