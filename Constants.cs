using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Chess";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 720;
        public static int SCREEN_HEIGHT = 720;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int COLUMNS = SCREEN_WIDTH / 8;
        public static int ROWS = SCREEN_HEIGHT / 8;
        public static int COLUMN_A = COLUMNS * 0;
        public static int COLUMN_B = COLUMNS * 1;
        public static int COLUMN_C = COLUMNS * 2;
        public static int COLUMN_D = COLUMNS * 3;
        public static int COLUMN_E = COLUMNS * 4;
        public static int COLUMN_F = COLUMNS * 5;
        public static int COLUMN_G = COLUMNS * 6;
        public static int COLUMN_H = COLUMNS * 7;
        public static int ROW_1 = ROWS * 7;
        public static int ROW_2 = ROWS * 6;
        public static int ROW_3 = ROWS * 5;
        public static int ROW_4 = ROWS * 4;
        public static int ROW_5 = ROWS * 3;
        public static int ROW_6 = ROWS * 2;
        public static int ROW_7 = ROWS * 1;
        public static int ROW_8 = ROWS * 0;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";
        public static string MISS_SOUND = "Assets/Sounds/miss.wav";
        public static string JOKER_LAUGH = "Assets/Sounds/laugh.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 10;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "LEVEL: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "VILLIANS DEFEATED: {0}";

        // BALL
        public static string BALL_GROUP = "balls";
        public static string BALL_IMAGE = "Assets/Images/bat_ringed (1).png";
        public static int BALL_WIDTH = 80;
        public static int BALL_HEIGHT = 27;
        public static int BALL_VELOCITY = 6;
        public static int SHOOT_BALL = 0;

        // WHITE PAWNS
        public static string PAWN_GROUP = "pawns";
        public static string PAWN_IMAGE = "Assets/Images/pawn_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;
        
        // WHITE KING
        public static string PAWN_GROUP = "kings";
        public static string PAWN_IMAGE = "Assets/Images/king_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;

        // WHITE QUEEN
        public static string PAWN_GROUP = "queens";
        public static string PAWN_IMAGE = "Assets/Images/queen_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;

        // WHITE BISHOPs
        public static string PAWN_GROUP = "bishops";
        public static string PAWN_IMAGE = "Assets/Images/bishop_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;

        // WHITE KNIGHT
        public static string PAWN_GROUP = "knights";
        public static string PAWN_IMAGE = "Assets/Images/knight_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;

        // WHITE ROOKS
        public static string PAWN_GROUP = "rooks";
        public static string PAWN_IMAGE = "Assets/Images/rook_white.png";
        public static int PAWN_HEIGHT = 90;
        public static int PAWN_WIDTH = 90;

        // RACKET
        public static string RACKET_GROUP = "rackets";
        
        public static List<string> RACKET_IMAGES
            = new List<string>() {
                "Assets/Images/100.png",
                "Assets/Images/101.png",
                "Assets/Images/102.png"
            };

        public static int RACKET_WIDTH = 106;
        public static int RACKET_HEIGHT = 80;
        public static int RACKET_RATE = 6;
        public static int RACKET_VELOCITY = 7;

        // BRICK
        public static string BRICK_GROUP = "bricks";
        
        public static Dictionary<string, List<string>> BRICK_IMAGES
            = new Dictionary<string, List<string>>() {
                { "b", new List<string>() {
                    "Assets/Images/010.png",
                    "Assets/Images/011.png",
                    "Assets/Images/012.png",
                    "Assets/Images/013.png",
                    "Assets/Images/014.png",
                    "Assets/Images/015.png",
                    "Assets/Images/016.png",
                    "Assets/Images/017.png",
                    "Assets/Images/018.png"
                } },
                { "g", new List<string>() {
                    "Assets/Images/020.png",
                    "Assets/Images/021.png",
                    "Assets/Images/022.png",
                    "Assets/Images/023.png",
                    "Assets/Images/024.png",
                    "Assets/Images/025.png",
                    "Assets/Images/026.png",
                    "Assets/Images/027.png",
                    "Assets/Images/028.png"
                } },
                { "p", new List<string>() {
                    "Assets/Images/030.png",
                    "Assets/Images/031.png",
                    "Assets/Images/032.png",
                    "Assets/Images/033.png",
                    "Assets/Images/034.png",
                    "Assets/Images/035.png",
                    "Assets/Images/036.png",
                    "Assets/Images/037.png",
                    "Assets/Images/038.png"
                } },
                { "y", new List<string>() {
                    "Assets/Images/040.png",
                    "Assets/Images/041.png",
                    "Assets/Images/042.png",
                    "Assets/Images/043.png",
                    "Assets/Images/044.png",
                    "Assets/Images/045.png",
                    "Assets/Images/046.png",
                    "Assets/Images/047.png",
                    "Assets/Images/048.png"
                } }
        };

        public static int BRICK_WIDTH = 80;
        public static int BRICK_HEIGHT = 95;
        public static double BRICK_DELAY = 0.5;
        public static int BRICK_RATE = 4;
        public static int BRICK_POINTS = 1;

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string WAS_BAD_GAME = "GAME OVER";
        public static string WAS_GOOD_GAME = "GOTHAM IS SAFE ... FOR NOW";
    }
}