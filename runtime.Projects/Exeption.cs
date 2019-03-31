using System;

namespace NDP_UE_CS
{
    // Derive an exception with a predefined message.
    class NotEvenException : Exception
    {
        public NotEvenException( ) :
            base( "The argument to a function requiring " +
                "even input is not divisible by 2." )
        { }
    }

    class NewExceptionDemo 
    {
        public static void Main() 
        {
            Console.WriteLine( 
                "dotnet", "HelloDockerTools.dll" +
                "generates the following output." );
            Console.WriteLine( 
                "\nHere, an exception is thrown using the \n" +
                "parameterless constructor of the base class.\n" );

            CalcHalf( 12 );
            CalcHalf( 15 );

            Console.WriteLine( 
                "\nHere, an exception is thrown using the \n" +
                "parameterless constructor of a derived class.\n" );

            CalcHalf2( 24 );
            CalcHalf2( 27 );
        }
    	
        // Half throws a base exception if the input is not even.
        static int Half( int input )
        {
            if( input % 2 != 0 )
                throw new Exception( );

            else return input / 2;
        }

        // Half2 throws a derived exception if the input is not even.
        static int Half2( int input )
        {
            if( input % 2 != 0 )
                throw new NotEvenException( );

            else return input / 2;
        }

        // CalcHalf calls Half and catches any thrown exceptions.
        static void CalcHalf(int input )
        {
            try
            {
                int halfInput = Half( input );
                Console.WriteLine( 
                    "Half of {0} is {1}.", input, halfInput );
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.ToString( ) );
            }
        }

        // CalcHalf2 calls Half2 and catches any thrown exceptions.
        static void CalcHalf2(int input )
        {
            try
            {
                int halfInput = Half2( input );
                Console.WriteLine( 
                    "Half of {0} is {1}.", input, halfInput );
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.ToString( ) );
            }
        }
    }
}
