namespace KataTraining.Tests
{
    /*
        Les r�gles de calcul du bowling sont relativement simples, 
        mais peuvent sembler un peu complexes pour les d�butants. Voici comment calculer les scores:

        Si un joueur renverse toutes les quilles en un seul lancer (un "strike"), 
        il re�oit 10 points plus le nombre de quilles renvers�es lors des deux lancers suivants. Par exemple, si un joueur r�alise un strike au premier lancer, puis renverse 7 quilles au deuxi�me lancer et 2 quilles au troisi�me lancer, son score pour le premier tour sera de 10 + 7 + 2 = 19 points.

        Si un joueur renverse toutes les quilles en deux lancers (un "spare"), 
        il re�oit 10 points plus le nombre de quilles renvers�es lors du lancer suivant. Par exemple, si un joueur r�alise un spare au premier tour (en renversant 7 quilles au premier lancer et les 3 quilles restantes au deuxi�me lancer), puis renverse 5 quilles au deuxi�me lancer, son score pour le premier tour sera de 10 + 5 = 15 points.

        Si un joueur ne r�alise ni un strike ni un spare, 
        son score pour le tour est simplement le nombre de quilles qu'il a renvers�es en deux lancers.

        Le score total d'un joueur est la somme de ses scores pour chaque tour, 
        plus les points bonus qu'il a �ventuellement gagn�s en r�alisant des spares ou des strikes.

        Si un joueur r�alise un strike ou un spare dans le dixi�me tour, 
        il a droit � des lancers suppl�mentaires pour terminer le tour et marquer des points bonus si n�cessaire.

        Le score maximum possible dans une partie de bowling est de 300 points, 
        en r�alisant 12 strikes d'affil�e (10 strikes r�guliers et deux lancers bonus pour le dixi�me tour).
    */

    [TestClass]
    public class BowlingGameTests
    {

        const int DefaultRollCount = 20;
        [TestMethod]
        public void TestGouttiereGame()
        {
            var game = NewGame();
            RollMany(0, game, DefaultRollCount);
            Assert.AreEqual(0, game.GetScore());
        }


        [TestMethod]
        public void Test_UneQuilleParLanceGame()
        {
            var game = NewGame();
            RollMany(1, game, DefaultRollCount);
            Assert.AreEqual(20, game.GetScore());
        }

        [TestMethod]
        public void Test_UnSpareGame()
        {
            var game = NewGame();
            game.Roll(6);
            game.Roll(4);
            game.Roll(3);
            RollMany(0, game, 17);
            Assert.AreEqual(16, game.GetScore());
        }


        [TestMethod]
        public void Test_AllSpareGame()
        {
            var game = NewGame();
            RollMany(5, game, 21);
            Assert.AreEqual(150, game.GetScore());
        }


        [TestMethod]
        public void Test_UnStrikeGame()
        {
            var game = NewGame();
            game.Roll(10);
            game.Roll(4);
            game.Roll(3);
            RollMany(0, game, 16);
            Assert.AreEqual(24, game.GetScore());
        }


        [TestMethod]
        public void Test_AllStrikeGame()
        {
            var game = NewGame();
            RollMany(10, game, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        private void RollMany(int nbQuille, BowlingGame game, int count)
        {
            for (int i = 0; i < count; i++)
                game.Roll(nbQuille);
        }

        private BowlingGame NewGame()
        {
            var bowlingGame = new BowlingGame();
            return bowlingGame;
        }
    }
}