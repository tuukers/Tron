using System;


namespace Tron.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Winner is to add points for a player if they win a round.
    /// </para>
    /// </summary>
    public class Winner : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of Winner.
        /// </summary>
        public Winner()
        {
            AddPoints(1);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
        }
    }
}