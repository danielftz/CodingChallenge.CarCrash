It's a normal day in the Meescan office with Andrea and Peter gone.
Eamonn is exchanging jokes on Cliq with Robyn. Amar is deep into his TikTok feed. Sofonias is watching Pluralsight. Meagan is finishing her cross-stitching art while simultaneously making her way through the study materials for an upcoming exam. Daniel just walked in. Everyone else is deep into a dart tournament while Rachel somehow manages to be on the phone and carry a conversation in all this noise.
The team is interrupted by some commotion on the street outside. Some hobos standing in the line for the injection site got into a fight and caused a traffic havoc. Michael snapped a picture of the street with his phone but then Ellen scored triple 20 and the team's attention turned back to the usual office affairs. All of a sudden, there's a huge accident outside. Police and ambulances on the scene. Maple Ridge police is famous for being swift so by the time the team go back to the window, the scene is almost completely cleaned and the traffic is restored. Typical!
Needles to say, the team is very sorry having missed seeing the accident. If they at least knew how many individual accidents have happened... Before you know it, they are arguing about this number (completely forgetting about the dart tournament and other activities that kept them busy before).
Someone has a brilliant idea - Michael has a picture and perhaps, they can figure out the number from the scene on the street just before the accident. So they ask the smartest team members (the programmes) to help.
Programmers being programmers, they realize that it is very likely that this situation will happen again, decide to write a program. So Eamonn makes a Trello card with formal requirements and they get to work:

Requirements
Write a program, that calculates a number of individual collisions that happened based on the direction of the cars in front of the office right before the accident. All cars going left or right were going at the same speed. You can assume that a car involved in an accident stops and becomes stationary at the moment of the collision.
Collision happens when a car in motion hits a car that is either moving in an opposite direction or is stationary. Any car that is involved in a collision and is in motion at the time counts as one (so head collision of two cars moving against each other counts as two, while car hitting a stationary car counts as one).

Program output
Your program should take a single string as an input. The string is comprised of '>' going right), '<' (going left), and '=' (stationary) signs indicating a car direction.

Program output
Your program should output a single number indicating the number of collisions.

Examples:
"><><" => 4 // two head on collisions
"<=>" => 0 // cars on the sides move away and the car in the centre stays put
">>=<><" => 5
">>><><<><<>>==<>==<><<>><><>=><=" => 26
