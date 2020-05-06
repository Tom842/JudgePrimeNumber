using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Text;

namespace JudgePrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("整数を入力してください");

            var strPNo = Console.ReadLine();
            var numPNo = int.Parse(strPNo);

            var Pnum = new PrimeNumber();      //Class PrimeNumber のインスタンスを生成

            var PBool = Pnum.IsPrime(numPNo);   //PrimeNumberのメソッド IsPrimeを呼び出し
                                                //入力された値を引数として渡す。

            if (PBool)
            {
                Console.WriteLine("{0}は素数です", numPNo);
            }
            else Console.WriteLine("{0}は素数ではありません。", numPNo);

        }
    }

    class PrimeNumber
    {

        /*
         * 
         * 素数とは？　→　1と自分自身以外の数で割り切れない自然数のこと
         * 合成数とは？→　素数以外の数のこと
         * 
         * エラトステネスの篩
         * 
         * 素数判定では、「合成数xはp≦√xを満たす素因子pをもつ」
         * 「合成数xはp≦√xを満たす素因子pをもつ」＝「xが合成数ならば、√x以下の約数を持つ」
         */

        public bool IsPrime(int num)
        {
            //if は処理が一行だけのときは{ }を省略できる。
            if (num < 2) return false; //1は素数ではない

            //処理が2行以上の時は{ }でブロックをつくる
            else if (num == 2)
            {
                return true; //2は素数判定
            }

            else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

            /*
             *
             */

            double sqrtNum = Math.Sqrt(num);　//素数判定 √num以下の約数があるか判定

            for (int i = 3; i <= sqrtNum; i += 2)　//i += 2 は i に2を加算。i = i + 2 と同意
            {
                if (num % i == 0)   // % は余剰(余り)を求める。 0になれば割り切れる
                                    //奇数で割り切れる場合は、素数ではない。
                {
                    // 素数ではない
                    return false;
                }
            }

            // 素数である
            return true;
        }


    }
}


