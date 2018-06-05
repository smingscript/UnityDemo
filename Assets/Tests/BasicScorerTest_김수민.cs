using NUnit.Framework;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;

namespace Assets.Tests
{
    class BasicScorerTest_김수민
    {
        [Test]
        public void 땡을_광땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("1");
            p1.AddCard(new Card(1, true));
            p1.AddCard(new Card(8, true));

            Player p2 = new Player("2");
            p2.AddCard(new Card(5, false));
            p2.AddCard(new Card(5, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

        [Test]
        public void 끗을_땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("1");
            p1.AddCard(new Card(6, false));
            p1.AddCard(new Card(8, false));

            Player p2 = new Player("2");
            p2.AddCard(new Card(2, false));
            p2.AddCard(new Card(2, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 끗끼리_큰_수로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("1");
            p1.AddCard(new Card(6, false));
            p1.AddCard(new Card(8, false));

            Player p2 = new Player("2");
            p2.AddCard(new Card(2, false));
            p2.AddCard(new Card(6, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }
    }
}
