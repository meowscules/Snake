using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake;

namespace SnakeTest
{
    [TestClass]
    public class AppleTest
    {
        [TestMethod]
        public void MyAppleTest()
        {
            SnakeLogic appleLogic = new SnakeLogic();

            int fieldSize = Snake.GameField.SIZE;
            int dotSize = Snake.GameField.DOT_SIZE;

            appleLogic.createApple(fieldSize, dotSize);

            int currentX = appleLogic.getAppleX;
            int currentY = appleLogic.getAppleY;

            bool isXTrue = false;
            bool isYTrue = false;

            if (currentX >= dotSize && currentX <= (fieldSize-dotSize))
            {
                isXTrue = true;
            }

            if (currentY >= dotSize && currentY <= (fieldSize - dotSize))
            {
                isYTrue = true;
            }

            if (!(isXTrue && isYTrue))
            {
                // Îøèáêà
                Assert.Fail("Error has been detected! Apple coordinates: X = " + currentX + " Y = " + currentY);
            }
        }
    }
}
