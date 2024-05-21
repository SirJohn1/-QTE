﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реализация_QTE
{
     internal class StoryLines
    {
        public static void StoryLine() {
            var Bank = () => WriteLine(@"                                                              
                                                     -%@@#=#@@@=                                                          
                                                -#@@@+-       :=%@@#-                                                     
                                            *@@@#=     --.  --    .-*@@@#:                                                
                                       -@@@#+.                         .=+@@@-                                            
                                  :+@@@=-       =#**  ##  #@@. .%*    .     -=#@@*:                                       
                             .+%@@#=. .  --      @*#+@=BANK@#-@@@@=     ::  . .-*@@@*:                                  
                         =@@@%*:     ::        @   +  = % .%* : :   %.        .:.    :+#@@@=                              
                 :-:-@@@@*.                    +:+==  -%.   -@= *@@.                       +%@@@=---.                     
                     :    +%##*****##########*+@@@%%@@+#@@@@--+#@%#@@%**##########******##+    .                          
     :+#%%%#%###*---.                                                                           .---=*#%%%%%%%#+.         
     .   :--:    ...::--==++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++==--:..      :--.   .         
     :+#+.  :--=======-----=========-------==========------------==========-------========--------======-.  :+#=.         
       :+=@.                                                                                              :%==.           
          @#.:---: -@@@@@@+  :=--=. +@@@@@*  .===-   *##########+  .-==-   +####+   ----:  =#####-  .-:::.%#              
          =#=-=== ++     =@@* :+=: *=    .@@@  :.  @@@@@@@@@@@@@@@@  ::  @@@@@@@@@@  =+: #@@@@@@@@@= :=--+#-              
           --     @ *%#*+-  @*    += *%#+=  @%    @@              @@    @@        @@    #@        .@.    +.               
            * .   @ .%%=@@  @@ :: *. %@:%@- @@    @#    %@#@@@%   @@    @* =@*@@@ *@  : @@ :@%@@@. @=    *                
            @   . % #   -  =#@  . -=-   :   *@ .  @% ..+-     @ . @@  . @.:+      *@    @+-:     :.@-    %                
            @   . + *   +  .+@ .: :--   * : .@ :  @%   .    . % : @@  . @  .    . =@  . @..    . . @:    %                
            %   . +=@%@*@=--+@ .:  #@@@*@*@ -@ :  @@:  @@@@%@=@ : @@  : @ #@@@### *@ .. %:@@@@%@++ @.    %                
            %   : +%@ .    *#% ::  @@ .   - +@ -  *#@@ @      @ . @@  : @:@:      @@ .  #-@.     -=@     %                
            %   : ++@:@ =-+=## .:  @@=@ +:@ +@ -  -  ==@@+=:*#@ : @@  : @.#@@@=+@ @@ :  *-@@%@+#%*-@     %                
            %   : # @@@@@@: %* .: :=+@@%@@* *@ -  ++   %@@@**+. . @@  - @- +#:-#* #@ :  *+ :%=-%*  @     %                
            %   : @       - @= .: ++      - @@ -  =*       .      @@  - @@        @@ :  *@        =@     %                
            %   - @       @ @- .. +#      @ @@ -  =*       #@@+   @@  : @@        @@ :  +@        *@     %                
            %   - @  --.:=  @:  . =* -=.-*= @@ :  -#         :#%= @@  : @@     .  @@ .  =@. .  == #@     #                
            %   - %.#@@*@@-:@   . .#:@@-@@@ @# :  -#           =@ @%  : @# ++.+@@ @@ .  :#+.--.@# @@     #                
            #   - +*@ : -  @@      @# : -  #@* -  -#  *@@@@@*-: # @#  : %*=#. :.  @@ .  :=@= - * :@@ .   #                
            #   = =@@ # *  @@      @@ * +. %@+ -  -# *@@@@@@@@@@  @#  : #*#- . .. @%    .=@= % # .@@ .   #                
            #   = -@@ @ -  @#      @@ # =  *#= - .:* @#        @  @+  . +*@- +  . @#     =@+ % -  @@ :   #                
            #   = -@@      @#      @@      @%- :  :# @@   %#: =@  @+  . :*@-    :.@+     =@* *    @@ :   #                
            #   = +%@@@*@@ @@      @@@@*@@ =@: : ..# %@ @=  #==@  @=  .  :@@@- -= @+     #@-@@*@# @@ :   #                
            # . = @.+@@@@@ -@      # @@+#@- @: : :.# #@  ==-   @  @=  :  . @@@@@: @# .   @=       @@ :   *                
          --+   . #      - .@      +        @      + +@    .+..@  @      -        @=     @=       @@     *=:              
         .=  =*++ +@=   #  @@ :++..@@-  *  @@:-**=:%:@@        -=@@.:**-:#@-  #  @@: +*: @@%     @@# +*+: .-              
         ..        :#-::- @%        =#:.* @#         @@+@@@@@@#@@+        :%.:+ @@        %@%%%#@@-        .              
         =*#%@@@%%#=. :*@@+ =#%%%%%*-  -@@* +#%%%%%# -@@@@@@@@@@+ =#%%%%%*-. +@@* :*%@@%#= -@@@@%: +%%@@%%++:             
     :*%##:                                                       .      ..                        .       =*##+          
 @@@@@%=+-           .:....          ..:...                                 .....                          .=+*@@@@@@-    
                                                                                                                     #*@@ 
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#     
 *:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::-=#@@@ ");

            var interBank = () => WriteLine(@"..........................................................................................................................  
  .**************#####*+##**+*+*********#*###*#**#*#####*###############****#*+=-=#@@%#####################################.  
  .******************#*%*####*#***************#*#*#***#*#*###########***##*******+=:=#@@%##################################.  
  .*************#*****+%+*####*#####***************##*#*##*#*##*################****+--=#@@%%##############################.  
  .*******************+%+**+*#****##****##********#*#*##*#**#*#*###############*###*#**+=-=#@@%############################.  
  .#######******#******%+****#+*##**#########*##********###############################***+=-=%@@%#########################.  
  .+++*#%%%#######****+#+****#********#*****##########*#******#*#*###################*####**++--=%@@%####################%%.  
  .+=-....:=+=+#%@@%%%#@##***#******#*##*#####*##########*###**#**#*##########################**+---%@@%###############%%@@.  
  .-==+*##*+=-......:...:+##%@%%%#****#*#***###*########*##**##*#####**#**##*#####################*+=-=@@@%#############+-..  
  .#####+======+++=-+#%%%+-.....+@@@@@@@%%#################*%######**#**#********#*###########*=-*#***+---@@@%##########%##.  
  .++==++#%%%@@@@@@@@@%#####%%%@-......-#@@@@@%%%#######*##*%###################********########%####****=-.-@@@%########%%.  
  .**+++=+==+++++++*##%%@@@@@@@@@@@@@@@*:....---+%@@@%%##%#*#********#######**+**************#**########**#*+-:=@@@%#######.  
  .+*+*++**++#***++****+*++++++++*##++-==+*+++++-....-=-.:::=+####***++*+***#######*****************##########*+=:+@@@%####.  
  .+*+*++*+++*++***+++**+******++++#==+*#**#%+++=====-..=%@@#-...=#@@@@@%##*###################################=+*=-.+@@@%#.  
  .+*+++=**+***+*++===++*+=--=+**+*%+++**++====+*#%%%@@@@@@@@@@@@#-....++%@@@##%%%###*###%*#*#*#**************#####**=-.+@@.  
  .+##+++*+++#****+=@=%+++#@@@=*++*%++***++++++++*+==++++++*##**#%##*++=-...:=:...-+#%%%##*#*#####%#####**#************+=-..  
  .+**++=**++#***++-@.@###@%*@-+*+*%+++**+++++++**+=++**=+====+++#=++==++#%@%%%@@@@+--.-*%@@@@@@%%@%%%%%%#+=====+++++***##*.  
  .+#***=#*+*****++-@.@%@@#=-@-**+*%++****++++++***=++*+=@%*+#+=*++**+++++=+#%%%##*++==-:.-=....--+++####%@@@@@@@@@@@@@@@@@-  
  .+##+*=#*+******+-@.@@@%%++@=**+*%+****+*+**++*#*=***+=@=@@@%=*++**++++*+++**+++==*==+#+-++*#**++*--...-*++#%############.  
  .+##*+=#*+*#****+=@:+-:=+*#@=**+*%*+******+****#*+***+=@+-%#*=*%+**++++*++=@@+@+=+#++##=-=+=++++++*###++@%*=****#########.  
  .+#*++=#+++*+*+*+==#@@@@@@@#+*+*+#+++++*****++*#*+#***=@@@@@%=**+******#++=@%*@+*##*+##=-+=+++++++++++=-+.......-==:..::-.  
  .+##**=#*+********++=------=+++++#++++++****++***+*+++====+*=+**+*+*+++*+++%@%@*=+**+##==++++++++++***=.@@@@@@@@@-@@@@@@@%  
  .+##*+=#*+++**#####++============*=-==++*******#*+#+**#%%#+=:-----:-=+**++**####--===+#=-+++++++++++++-.@@@@@@@@%.#@@*#+%.  
  .+##*+=#*++#%*==--.+@@@@@@@@@@@@@@@@@@@++*+#**##*+*+@#-.::.@@@@@@@@@@**#+##-:-:-@%@%@@#--=+=======++++=.@@@@@@@@%.#@@*#+#.  
  .+##**=#*++#@*++++-+@#***###*#%+#*####%+***#*++*+---*=.....#*++=#=+=-.:-:=+.....@%@%@@+...==*#:......=+=%....+@@#.#@@@@@@+  
  .+##*#=#**+#%*++++-+@#######+##==+%@@#-.....:-+..+%*#*====.#+++=+==-=----=--=+%-###*+++@@=-=#%@@@@@@@++=+-*%@@@@%.#@@@@@@+  
  .=##++-+*##%@%*+++=+@########%@@@@+--.@@@@@@@.#%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#=+***#+#@@###=%@@@@@......:=%@@@%:@@@@@@@%  
  .***#%@@%+++**++++-+@#####%@%%%#@@...+@@@%%@%.%@@+===%@@@@%%%%%%@@%%%%@%%@%@@@@...............:#@@@@@@@@@@@@@@@@%-++*#**#-  
  .*#*++=+=+++=+++**=*@####%#......:+#+.@@@@@@=-*@@@@@@@@%@@%%%@%@%@@@@@@@@@%@@%@=-+#@@@@@@@@@@@@@@@@@##%%%##+@@@@%-++=====.  
  .*****++*+++*+++++=%@@@@@@@@@@@@%@@@@#@@@@@@@%@@@@%%%%%@%@%%%@@@%@%@@@@@@@%@@@@@@@@@@@@@@@%@%#%@@@@@#+#####*@@@@%@@@@@@@@+  
  .*##############%@@##-++===+=-+##+++=........-%@@@%@@@@@%@%@@%%@@@@@@@@@@@%@%@@##%%%%%%%#####+#@@@%@#+#####+@@@@%#%%%@@@@-  
  .%%##*++++=+=====-.--:---::::...............:--##%@@%%%@%%@@@@@@%@@@@@@@@@%%@%@#*########%###*%@@@@@#*%@@@@@@@@@#*#######.  
  .-==+++*###%%%###:.............+@@@@@@@@@@@@@@@@@@%@@@@@@%@%@@@@@@@@@@@@@%%@@%@#*##%######%##*%@@%@@%@@@#*..-.:-+*#######.  
  .==-:.............:#@@@@@@@@@@@@@@@@@%%%#%%####@%%@@%%%%@%@@@@%@@@@@@@@@@@%%%@@#*###########%#%@%%%@#....-+#**++*********.  
  ......=@@@@@@@@@@@@@@@@@@%%%%%%%#%%%%%%%%%%%%##@@%%@%%@%%%@@%@@@@@@@@@@@@%%%%%@#*%%#%%%%%@@@@%@@@@@@=+%@@@%#####*******+#.  
  @@@@@@@@@@@@%%%%%%%%##%%%%%%%%%%%%%%%%%%%####**@%%%%@%%%%@@@@@@@@%@%%@%@@%%%%%@#*##%@@@@@@%%@.#@-..=*#############*#**##*.  
  :%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%##########**@%%%%%%%%%@=#@@@@@@@@@@@@@%%%%%@#%@@@@##%%:...:==+******##***#******##***#.  
  :%%#%%%%%%%%%%%%%%%%%%%%%####################**@%%%%%%%%%@...-++*@@@@@@@@%%%@@@%**#%*....=%@@%%###*###***#******####*##*#.  
  .%%%%%%%%%%%%%%%#########%%##################*#@%%@%%%%%%@#@@@@@@@@@@@@@@%%%%@@#-....+%@@%###**####*#*#****#***##+*****#*.  
  :%%%%%%%%########%############################*@%%%%%%@%%@#@%#++=:...:+@@@@@@@@-.#@@@%%#########**#*##*******##+**#**#*##.  
  .#%##########%#%##%##################%#######*#@%%@%%%%%%@-====+#%%@@@@@@@@#:.=*%%%############*##*****#***##*****###**#*.  
  .####%##%#%%%########%#########################@%%%%%%%%%@-*%%@@@@@%#+-...:=+*#*#*******#***+*******#*+*##***********##**.  
  .##%##%######%%%#######%#######################@%%%%%%%%%@#@@@@%*++++++**+***#****####*##**#********+*##************#***#.  
  .####%#%#########%#######%####################*@%%%%%%%%@@##*+++*+*#**#####**#**###+****************#*************#****##.  
  .%%#######%%########%####################%%%@%#@%%%%@@@@@@=++***#**#*##*****####**#*##***********##*********#***#*****#**.  
  .%##%########%%#####################%%@@@@%#+=%@@@@@@@@=.-=#*##*###******####*#*****************#*++************#***##**#.  
  ...............................................+=.........................................................................");

            var gold = () => WriteLine(@"
.................:::=+..........:...+-:::#@..:....:...........:.........::-...............@@#::-:::::-+:::::--:
..:::+++###-+*=+#**=@@%**#+-=##...@@@#%@@...::::::-::::::::::::::::::::.....:::::::::::::...@@@##%%%%###%@%%%%-
.::::...::-::.==##+:#@%--++**#..@@@*=@#.............:::::::::::::::::::::::::::::#.-:-:::::...@@@*#@#%@%%%##%%-
.::::..........:::-::@@=-=+*...@@@:@@..:-.@:@:@:@.@.::::::::::::::::::::::::::::.%.#.-:::.#.*.#.@@##%#%%%%%%##-
.:::.::::::::=:#@@@@=@@%+*##.@@@@:@@.:.%..:.@.%.@.@.::::::::::::::::::::::::::.@.%.@.:....:.:.#.:@@%%%%%%%@@%@=
.::::@@@@@@@@@@@@@@@@@@@@@@:%@@::@.*+@.@%@@.@.@.@.@.::::::::::::::::::::::::::.@.#.-.@@@@@@@@@@@@@*%%%##%%%%*@-
.::::*-@@@%%%%@@#*::...::#.@@@:=@=.@.@.@.:..@.%.%.@.::::::::::::::::::::::::::.@:@+@+@@@#@*@%@%@@@@#@#%%##%@%%-
.....%#=@@@@@@@@@@@@%#=::.@@@:+@:..@=@.@.%..%:@.@.@.:::::::::::::::::::::::-::.@.#.#.:-@.@:@=*+=@-@:@%%%%%#%%@=
.%@@+.@%*@@@@@%@@@@@@@@*:@@@#@@.+..@@@:@:@.-*:%.@.@.::::::::::::::::::::::.*-#:@.@:@:**@.@=@**@+@:@:@+%%%%##%%=
..+@@#.:::+@@#%%%#%%###--@@*#@@:@.-%...#:@:@@@@*@=@:::::::::::::::::::::-::%=+:@.@:@:*#@:@*@%+@=@:@+@*@%%%%###=
..:::*@@**+@@@%%##%%%%#=@@+#%#@:@.::.....@.....:*.@.:::::::::::::::::*::::.#+=:@.@:@:+%@-@%%%=@=@-@*@#@##%%#%%-
..@@...%+...#@%%%%%@@@@#@%#%#@@@@@@@@@@@@@*@#@%@*@@.-::-::-:=:--:-:::::+%+-%=#-@.@:@:=@@=%@*@=@+@=@%%#@%%%%%%%-
+@@@#...#:...@@%%##@-.@@%+%##%@%%#@=@:@:@@:@.@:@:%@.::::::-::::-:-::::#.=%:@+#-@.@:@=-%@+*@+@-@=@+@@##@@#%%%%%-
.:@@@:...@....@@@#@@@+%@###+@#%@@#@:@:@:@%:@.@:@:#@.::.-::-:*.:=.:.-::%=+*:@=+:@.@:@=:@@**@+@-@+@*#@#%@@#%%%%#:
..:@%@:..*%:=:@@*::..:@@#%%=@*@@@*@:@:@.@-*@:@:@:*@:@@:+:=..%.++:+:=:-:::=.@#%+@:@:@*:@@+*@=@=@*@=#@*%@@%%%#%%:
.-:@@#@=*+@*+-:@@%:%@@@%+##+@+@@###-@:@.@:@@:@+@-#%:-#.#-#.-@.##-*:#+*%+%%:@+**@:@:%=:+%=-@:@:@-#:*@=%@@%%#%@#:
:%%@@@@#%#@+#*:@@@-:.@@#%@%*@#@#+#:-=:#.@.*::::::::-*+.=:@+-%:-+-*:=-:%%@@%@@@@@.@:@%@%@@@@@@@@%@@@@%@@@%%%@@%:
:@=.+.::##@+*#-@+..@@@%##%#*@#@#@@%@@@@@@@@@@@@@@@@@@@@@@@@@@%@@%@@@@@=@-:::.#-@:%:*#:@:@:@:@=%+-@=@:@%@%###@#:
:@.+@=@@##@@+%*#@::@@@##%%#=@#@+:@:%::#.%.@:-::#.#:........................@=@=@:*++@:@:@-@=@#%%=@=@=@%@@%%%@%:
:@@@::@@*%@@=@%%@@@@@@###%%=@@@#:@:@:%#=@.@-#==@:@==.:::::::::::::::.%%%*..%.#:@:=#=@:@:@:@+@%#@:@=@+@%@##%%@#:
:*#@@@@%+#%@*@##@###%@@*#%%=@@%%:@:@:@-*@.@:@-+#:@:*.::::::::::::::::%...::@=@=@:-@:@:@:@:@+@%*@:@-@+@%@%#%%@#:
:**@##@%#@@%%##*@+==@+@#*#@#+@%@:@:@:@-*@:@:@+*%-@:%.::::::::::::::-:@%@@@#-@@@@::@:@:@:@:@+%%=@:@-@+@@@###@#*:
:%+@%%@#%%**@*#+@@-:@%@#+%%%+@@@+@:@:@-%@:@:@-##-@:#.:::::::::::::::.........:@@*:@:%:@:@:@+%%-@:@:@=@@%*%%@##:
:#*%#%@@@@##@*%*@@@@@%@%**%%**@#%@:@:@:@*-@:@:#--@:*.::::::::::::::::::::::::...::@:@=@:@:@+%*:@:@-@*@@###@**#=
:##@@@@.:%#*%*%*@@%@@%%%%+%%#+@*@+-*:@:@:*::@:@:=@=*.:::::::::::::::::::::::::.%:#=:+:@*@:@+@@#@-@+@%##*##@=*=*
:#*@.:@@@@%%#%%*@@%%%%@%#%=%%#*@@@@@@@@@@@%@@@@@@@@%.:::::::::::::::::::::::::.-+=@:@+@:@:@@=@:@:@@%@%+##@***%*
:##@@@%%*@@@=@%#@@%@%##**@%=@%*+@+@:+%:#=++:#:+::#:#:::::::::::::::::::::::::::.-:-:*:@:@:#@:@:@-%@@#=*#@+=**@+
:#*@@@@%*%#%:@#@@%%%%*#*+=@#=@#+#%@=%%+@+%#+@+@=#%+@::::::::::::::::::::::::::.=@:@:@:@:@+=@:@-@#@@*=+*@+=+=@@-
:#*@#%%**@@#=@#@%%##%##*#+=@*-@#+*@*@#*@=@*+%=@-%%*@...:+::::::::::::::--:::=::-@@@:@:@:@@-@:@+@@@+:=+@+=--@@%-
:+*@%%#*@@@-@%%#**+=====++=+%*-%*+*#@%#@=@+*@-@=%%#@-++++%-----:::::-:-:::::=:=:@.@-@:@:%@:@:@@@=::-#@-=--@@%%-
:+@%#@+=@@#:@*@@@@%@%%%*+=+--#*-%#==#@@@=@+@@=@+%%#@-+%+=-::=:::::-:-:-::=+:--=.@.@@@-@+*@:@@@#=:-=@#--:#@@%%@=
:*@@@@**##:@#@@@@@@@@@@@@@@@%##+--@-::@@@@-@@*@*@*@@%@==:..+=-:##%*+----+-:-=:#.@.@.@#@*-@@@%:::++@::::@@@%%%%=
:%#:@#+%@+*%@@@@@@@@@@@@@@%##**#*-:*@:::%@%@*@@%@@@@@+::-#+::+::....--==-=--*=@@%@@=@*@@@@:..:#%@::::=@@%%%%%%=
:@@@@-@@*=%@@@@@@@*@+**.%@%####*#@:::*@:.:+@-::...-..%+=-=+#=*+%%%%%%%#*#*##*%+*-..::@@::..:::.::::.@@@#%@%%%%=
-@@*+%@#+@@@@@@%#@@:..@@@@%%%##*#%@@:::+@:...%@%@:...........:................::=+@@=...::::::-:..@@@%%%#%%%%%=
-%++%@#*@#=--::-=-=@@@@#%@%%%####*@@@@:.::@@.....@#@.%%%%%%+---:-------+%%@@@@@-.....::::::::...@@@@##%%%%%%%%=
:=:-*:-+::::::::::::::::-*--:::::.....+%:....:#......:.........................:-:............%@@::::-:------=:");

            Bank();
            //выносим охрану на входе
            WriteLine("Pablo: Ну, как будем грабить? По тихому(1) или прорвёмся(2)?");
            int answ1 = Convert.ToInt32(ReadLine());
            Pablo pablo = new Pablo("Пабло", true, true, true);
            Chikatalo chikatalo = new Chikatalo("Чакатало", true);
            int timer=0;
            switch (answ1)
            {
                case 1:
                    timer = 15;   

                    // +времени к таймеру на ввод символов
                    //QTE
                    Program.Story_2();
                    Thread.Sleep(5000);
                    //QTE
                    pablo.PrintHaracteristick();
                    chikatalo.PrintHaracteristick();
                    Thread.Sleep(5000);
                    Program.Story_3();
                    Thread.Sleep(5000);
                    interBank();
                    //QTE
                    pablo.PrintHaracteristick();
                    chikatalo.PrintHaracteristick();
                    Thread.Sleep(5000);
                    gold();
                    Program.Story_Final();
                    break;
                case 2:
                    timer = 10;
                break;
            }

            //QTE  и проверку на жизнь ног(если проходит то ничего не трогаем, а если нет запускаем с таймером 10)
            Program.Story_2();
            //QTE
            pablo.PrintHaracteristick();
            chikatalo.PrintHaracteristick();
            Program.Story_3();
            interBank();
            //QTE
            pablo.PrintHaracteristick();
            chikatalo.PrintHaracteristick();
            gold();
            Program.Story_Final();


                    Program.Story_2();
                    Thread.Sleep(5000);
                    //QTE
                    pablo.PrintHaracteristick();
                    chikatalo.PrintHaracteristick();
                    Thread.Sleep(5000);
                    Program.Story_3();
                    Thread.Sleep(5000);
                    interBank();
                    //QTE
                    pablo.PrintHaracteristick();
                    chikatalo.PrintHaracteristick();
                    Thread.Sleep(5000);
                    gold();
                    Program.Story_Final();
                    break;
            }







        }

    }
}
