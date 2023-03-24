
**Niveau :** Moyen

Le jeu se compose de 10 tours. Dans chaque tour, le joueur a deux lancers pour faire tomber 10 quilles. Le score du cadre est le nombre total de quilles abattues, plus les bonus pour les strikes et les spares.
 - On parle de r�serve lorsque le joueur fait tomber les 10 quilles en deux lancers. Le bonus pour ce cadre est le nombre de quilles abattues au prochain lancer. 
 - On parle de strike lorsque le joueur fait tomber les 10 quilles lors de son premier lancer. Le cadre est alors compl�t� par un seul lancer. Le bonus pour ce cadre est la valeur des deux lancers suivants. 
 - Dans le dixi�me carreau, un joueur qui a obtenu un spare ou un strike est autoris� � lancer les boules suppl�mentaires pour terminer le carreau. Toutefois, il ne peut pas lancer plus de trois boules dans le dixi�me tour.


Les r�gles de calcul du bowling sont relativement simples, 
mais peuvent sembler un peu complexes pour les d�butants. Voici comment calculer les scores:

Si un joueur renverse toutes les quilles en un seul lancer (un "strike"), 
il re�oit 10 points plus le nombre de quilles renvers�es lors des deux lancers suivants. Par exemple, si un joueur r�alise un strike au premier lancer, puis renverse 7 quilles au deuxi�me lancer et 2 quilles au troisi�me lancer, son score pour le premier tour sera de 10 + 7 + 2 = 19 points.

Si un joueur renverse toutes les quilles en deux lancers (un "spare"), 
il re�oit 10 points plus le nombre de quilles renvers�es lors du lancer suivant. Par exemple, si un joueur r�alise un spare au premier tour (en renversant 7 quilles au premier lancer et les 3 quilles restantes au deuxi�me lancer), puis renverse 5 quilles au deuxi�me lancer, son score pour le premier tour sera de 10 + 5 = 15 points.

Si un joueur ne r�alise ni un strike ni un spare, 
son score pour le tour est simplement le nombre de quilles qu'il a renvers�es en deux lancers.

Le score total d'un joueur est la somme de ses scores pour chaque tour, 
plus les points bonus qu'il a �ventuellement gagn�s en r�alisant des spares ou des strikes.

Si un joueur r�alise un strike ou un spare dans le dixi�me tour, 
il a droit � des lancers suppl�mentaires pour terminer le tour et marquer des points bonus si n�cessaire.

Le score maximum possible dans une partie de bowling est de 300 points, 
en r�alisant 12 strikes d'affil�e (10 strikes r�guliers et deux lancers bonus pour le dixi�me tour).


    # Bowling Game Classic

Attention, pour ce kata, on ne s'int�resse qu'aux parties termin�es et correctes.  
La version plus difficile est [ici](../BowlingGameHardcore/README.md)

## Exigences

�crivez une classe Game qui poss�de deux m�thodes :
1. **void roll(int)** est appel� chaque fois que le joueur lance une boule. L'argument est le nombre de quilles abattues.
2. **int score()** renvoie le score total pour cette partie.

## Aide

### Step 1 - R�gles classiques

Entr�e : vide  
Score attendu : 0

Entr�e : On roll 20 fois 0   
Score attendu : 0

Entr�e : On roll 20 fois 1  
Score attendu : 20

### Step 2 - Le Spare

Entr�e : On roll 7, 3 puis 4 & 17 fois 0  
Score attendu : 18

### Step 3 - Le Strike

Entr�e : On roll 10, 3 puis 4 & 16 fois 0  
Score attendu : 24

### Step 4 - Le cas du g�nie

Entr�e : On roll 12 fois 10  
Score attendu : 300