using System;
using System.Collections.Generic;
using System.Data;
using Tron.Game.Casting;
using Tron.Game.Services;


namespace Tron.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
<<<<<<< HEAD
                Growth(cast);
=======
>>>>>>> a61560c184f4a295853b9f16365471da98cb0bd3
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>

        private void Growth(Cast cast)
        {
            Player player1 = (Player)cast.GetFirstActor("player1");
            Player player2 = (Player)cast.GetFirstActor("player2");
            //Score score = (Score)cast.GetFirstActor("score");
            //Food food = (Food)cast.GetFirstActor("food");
            
            
            
            int points = 1;
            player1.GrowTail(points,1);
            player2.GrowTail(points,2);
            //score.AddPoints(points);
            //food.Reset();
            
        }

        /// <summary>
=======
>>>>>>> a61560c184f4a295853b9f16365471da98cb0bd3
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Player player1 = (Player)cast.GetFirstActor("player1");
            Player player2 = (Player)cast.GetFirstActor("player2");
            Actor head1 = player1.GetHead();
            Actor head2 = player2.GetHead();
            List<Actor> body1 = player1.GetBody();
            List<Actor> body2 = player2.GetBody();

            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;
            Point position = new Point(x, y);

            if (isGameOver == false)
            {
                foreach (Actor segment in body1)
                {
                    if (segment.GetPosition().Equals(head1.GetPosition()))
                    {
                        isGameOver = true;

                        Actor message = new Actor();
                        message.SetText("Player 2 Wins!!!");
                        message.SetPosition(position);
                        cast.AddActor("messages", message);
                    }
                    if (segment.GetPosition().Equals(head2.GetPosition()))
                    {
                        isGameOver = true;
                        Actor message = new Actor();
                        message.SetText("Player 1 Wins!!!");
                        message.SetPosition(position);
                        cast.AddActor("messages", message);
                    }
                }
                foreach (Actor segment in body2)
                {
                    if (segment.GetPosition().Equals(head1.GetPosition()))
                    {
                        isGameOver = true;
                        Actor message = new Actor();
                        message.SetText("Player 2 Wins!!!");
                        message.SetPosition(position);
                        cast.AddActor("messages", message);
                    }
                    if (segment.GetPosition().Equals(head2.GetPosition()))
                    {
                        isGameOver = true;
                        Actor message = new Actor();
                        message.SetText("Player 1 Wins!!");
                        message.SetPosition(position);
                        cast.AddActor("messages", message);
                    }
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                Player player2 = (Player)cast.GetFirstActor("player2");
                Player player1 = (Player)cast.GetFirstActor("player1");
                List<Actor> segments1 = player1.GetSegments();
                List<Actor> segments2 = player2.GetSegments();

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                // Actor message = new Actor();
                // message.SetText("Game Over!");
                // message.SetPosition(position);
                // cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments1)
                {
                    segment.SetColor(Constants.WHITE);
                }
                foreach (Actor segment in segments2)
                {
                    segment.SetColor(Constants.WHITE);
                }
            }
        }

    }
}