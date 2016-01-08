using oselo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace oseloTest
{
    
    
    /// <summary>
    ///GameTest のテスト クラスです。すべての
    ///GameTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class GameTest
    {


        private TestContext testContextInstance;

       


        /// <summary>
        ///Game コンストラクター のテスト
        ///</summary>
        [TestMethod()]
        public void GameConstructorTest()
        {
            Game target = new Game();
            Assert.Inconclusive("TODO: ターゲットを確認するためのコードを実装してください");
        }

        public void CreateBordTest()
        {
            Game target = new Game();
            target.CreateBord();
            
            Assert.IsNotNull(target.CurrentBoardState);
        }
    }
}
