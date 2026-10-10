using BlaisePascal.PlayerHomework.Example1.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExamples.Example1.DomainTest
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevel1()
        {
            //Arrange - Act
            Player player = new Player("Mr. Test");

            //Assert
            Assert.Equal(1, player.Level);
        }
    }
}
