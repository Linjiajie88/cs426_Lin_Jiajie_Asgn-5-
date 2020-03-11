Player Interaction Pattern: Player vs. Player
 
Objective: Capture
 
Procedures: 
A/D to control the birds movement 
Space to jump 
 
Rules: When the bird hits the targets, it will increase or decrease their score 
 
Resources: speed boosts
 
Conflict: Missing cache 
 
Boundaries: edges of map surrounded by the library 
 
Outcome: The bird who reached the setting score wins
 
Non-plain-vanilla procedure/rule (see the Hw02 handout for what would qualify as an unusual procedure/rule): the game has an endless map, and objects will keep moving forward to the bird


Brief game idea: Players are represented as birds. Each birdie is ALU inside the computer in the library, they are trying to get the data that CPU need from memory to make the computer work properly. When the birds get the needed data is a hit which represent by the birds hit the “good” target and increase points, otherwise is a miss which represent by birds hit the “bad” target and deduct points. Also, whenever another player joins, the number targets are increased.

Sources--
monitor image: https://pixabay.com/vectors/monitor-screen-computer-electronics-1130493/
scene switch script: https://www.youtube.com/watch?v=FSt5xrFHaFU
binary image: https://www.scienceabc.com/innovation/how-to-read-binary.html
grid image: https://www.shutterstock.com/video/clip-4017094-virtual-computer-electric-circuittech-power-lines-grid
youtube networking tutorial: https://www.youtube.com/watch?v=UK57qdq_lak&list=PLPV2KyIb3jR5PhGqsO7G4PsbEC_Al-kPZ

Things Added： 
Two lights, one of the oragan ligh(spot ligh) was on the very front of the map which is make the gameplay area like a stage, the second ligh(point ligh) was on the middle of the map which will project on the ball oject shooting to the player, since the balls will reflect and it make player confused on judge that was a "good" or "bad" cache.
Sound effects: when the player catched tha bad cache will play a "explosion" sounds, and good cache will play a "good magical" sound.
physics constructs: one of the block in the center of the gameplay area, it restrict players movement, and one speedCache will locate in the area which is a collisionsion.
BillBoard: A welcome billboard in the center of the map.(Since our gameplay will not change the rotation of the Player, you may change the rotation manually to test the billboard)
