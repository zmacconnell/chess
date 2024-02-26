using Unit06.Game.Casting;
using Unit06.Game.Services;
namespace Unit06.Game.Scripting
{
    public class MoveBallAction : Action
    {
        private KeyboardService _keyboardService;

        public MoveBallAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Weapon ball = (Weapon)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = ball.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();

            if (Constants.SHOOT_BALL == 0)
            {

                Racket batman = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
                Body batmanBody = batman.GetBody();
                Point batmanPosition = batmanBody.GetPosition();
                int batX = batmanPosition.GetX();
                int batY = batmanPosition.GetY();

                position = new Point(batX, batY - 50);
                body.SetPosition(position);
                
            }
            else
            {
                ball.Release();
                position = position.Add(velocity);
                body.SetPosition(position);
            }


            // if (_keyboardService.IsKeyPressed(Constants.SPACE)) {
            //     ball.Release();
            // }
        }
    }
}