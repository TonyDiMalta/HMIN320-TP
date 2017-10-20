# HMIN320-TP

Master 2 IMAGINA - TP Unity

## Partie 1

### Mise en situation

Ajout du personnage 'BoxBoy' dans la scène sur une plateforme et d'un cube flottant au dessus de lui.
Voir sc1.

### Les matériaux

Ajout d'un fond derrière le personnage et d'une texture à celui-ci ainsi qu'au cube flottant.
Amélioration de l'éclairage du 'BoxBoy'.
Voir sc2.

### Et la lumière fut!

Ajout d'une lumière de type PointLight pour éclairer un cube dans une boîte.
Voir sc3.

```
Ce point du TP n'apporte rien à la scène et n'est plus utile par la suite.
```

### Les scripts

Ajout d'un script de déplacement au personnage.

### Le graphe de scène

Ajout d'une épée dans la main du 'BoxBoy'.

### La physique

Ajout d'un rigidbody à un nouveau cube pour constater qu'il ne flotte pas comme le précédent.

### Duplication

Ajout de plusieurs cubes identiques au précédent, ceux-ci conservent ses caractéristiques.

### Variables exposées

Ajout d'un script de suivi à la caméra avec pour cible le 'BoxBoy'.
Voir sc4.

```
Les objets ont bien le comportement attendu, ils réagissent à la physique (ils tombent ici car ils sont empilés avec de grands espacements).
Ils sont également poussés par le personnage quand celui-ci s'en approche alors qu'il est déjà au contact de l'objet.
Le script précédent nous permet d'appliquer les changements de notre choix à l'objet de notre choix tandis que le graphe de scène applique tous les changements du parent à ses enfants.
```

## Partie 2

### Le third person character

Ajout du ThirdPersonCharacter des assets stantards dans la scène.
Ajout d'une sphère qui jouera le rôle d'obstacle au personnage pour attendre l'épée du 'BoxBoy'.
La sphère est combinée à un PhysicsMaterial pour ajouter des rebondissements et la rendre plus dangereuse.
Voir sc5.

```
Je trouve la génération d'objets mal organisée, j'ai donc désigné GameObjectControl comme parent des sphères.
```

### L'épée

Ajout d'un script pour récupérer l'épée du 'BoxBoy' en étant suffisamment proche.
Voir sc6.

```
Le script déclenche une erreur sur Unity, il manque la ligne de déclaration de la variable player.
Repositionner l'épée selon le nouveau personnage est vraiment pénible, d'autant plus que l'épée reste statique tandis que le personnage exécute des animations.
De plus, la fonction continue de s'exécuter à courte distance du 'BoxBoy', ce qui m'a sauté aux yeux lorsque l'épée grandissait de plus en plus sans s'arrêter.
J'ai donc ajouté un booléen pour déterminer si l'épée avait changé de propriétaire avant de calculer la distance.
```

### Les plateformes

Ajout de plateformes pour attendre la plateforme du 'BoxBoy' ainsi que les limites du terrain (trop bas sur l'axe Y recharge le niveau - càd la scène).
Voir sc7.

```
Pour continuer de générer des météorites (les sphères rouge et noir) à l'infini, j'ai préféré utiliser une fonction "InvokeRepeating" et détruire les objets (sauf le player) qui sortent des limites du terrain.
```

### Stargate

Ajout d'un changement de scène lorsqu'on s'approche suffisamment de la fontaine.
Pour le faire, j'ai décidé de reprendre le calcul de distance utilisé pour l'épée afin d'éviter d'ajouter un collider pour bénéfier du trigger.
L'ajout des scènes au build permet maintenant de se téléporter de notre première scène à la seconde en rentrant dans la fontaine.

## Partie 3

### Les pièces d'or

Création d'un cylindre en forme de pièce auquel on ajoute un script pour la récupérer et un son à jouer dans ce cas.

### L'interface

Ajout d'un texte pour informer le joueur du nombre de pièces récoltés en haut à gauche de l'écran.

### Timer

Ajout d'un timer pour inciter le joueur à se dépêcher (le texte correspondant au timer apparait en haut à droite de l'écran de jeu).
Voir sc8.

### Dans la continuité du temps

Ajout de variables statiques pour conserver le score ainsi que le temps de jeu restant dans la deuxième scène.
Pour conserver ses informations, on a également besoin d'un canvas et d'un objet 'world' dans la scène intérieure.

### Bonus

Lorsque le joueur a trouvé toutes les pièces, on lui indique en précisant 'MAX' avant le nombre de pièces récoltées.
Pour obliger le joueur à ramasser un certain nombre de pièces, on rajoute une condition au changement de scène (stargate).
Enfin, on ajoute des pièces factices qui retirent un point lorsque le joueur en ramasse une.
Pour les distinguer des vraies, j'ai changé leur couleur (material) ainsi que le pitch du son quelles font lorsqu'elles sont ramassées.
Pour des soucis de claretés, le texte "Coin" est remplacé par "Score".
Afin de permettre au joueur de changer de niveau même s'il ramasse toutes les pièces (vraies et fausses), le score requis est la différence des deux.
Voir sc9.

```
Ces manipulations permettent de se familiariser pas à pas avec Unity, cependant la partie sur 'PointLight' n'est pas vraiment nécessaire.
La version finale manque de feedbacks pour le joueur qui ne sait pas ou aller, que faire...
Il faudrait ajouter un menu de départ avec les touches, l'objectif, ainsi que des indications en jeu concernant les actions à réaliser.
Exemple : ajout d'un message indiquant le nombre de pièces requises au début de la partie, ainsi qu'un message rappelant ce nombre lorsqu'on entre dans la fontaine trop tôt.
```
