static void gussing_number(){

            int secert_number = new Random().Next(1,101);
            int attempts = 0;
            bool iscorrect = false;
            
            Console.WriteLine("Welcome to the gussing game ");
            Console.WriteLine("I'm thinking of a number between 1 and 100");
            while(!iscorrect){
                Console.WriteLine("Take a guss : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if(guess == secert_number){
                    iscorrect = true;
                    Console.WriteLine("Congratulation ! You guessed the correct number  in a "+attempts+"attempts");                      
                }
                else if(guess < secert_number ){
                    Console.WriteLine("Too Low! Try again ");
                }
                else{
                    Console.WriteLine("Too High! Try again ");
                }
            }
        }