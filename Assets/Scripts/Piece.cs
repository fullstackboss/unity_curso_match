using UnityEngine;

public class Piece : MonoBehaviour
{
    public int x, y;
    public Board board;
    public void Setup(int x_, int y_, Board board_)
    {
        x = x_;
        y = y_;
        board = board_;
    }

    public enum type
    {
        elephant,
        giraffe,
        hippo,
        monkey,
        panda,
        parrot,
        penguin,
        pig,
        rabbit,
        snake
    };
    public type pieceType;
}
