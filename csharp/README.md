


FR
===
--
La solution peut être ouverte via le fichier csharp.sln , le projet est compilé .Net Freamwork 4.5.2.

Les packages suivants sont nécessaires :
										nUnit
										ApprovalUtilities
										ApprovalUtilities.Net45
							
Modification :

1-> Création de deux nouvelles classes :	Rule
											Product
		La classe Product contient la classe Rule et la classe Item.
		Rule=> représente les règles du produit

2-> La classe Program à été modifiée :	La méthode BuildProduct permet d'initialiser une liste de produit.
											La méthode UpdateQuality2 est appelée

3->la classe GildedRose à été modfiée : Le constructeur  GildedRose et la méthode UpdateQuality ont été marqué comme Obselete.
										Le constructeur GildedRose  avec comme argument une liste de produit et la méthode UpdateQuality2 à été ajoutée

4->Quelque test unitaire ont été ajouté dans les classes GildedRoseTest et ApprovalTest.
	La classe approvalTest utilise la méthode ThirtyDays2 avec un nouveau jeux de donné qui sont dans  le fichier ThirtyDays2.txt

	
--------------------------------------------------------------------------------------------------------------------------------------------------------------
	
EN
==


You can open the file csharp.sln to work in solution, the project is compiled in .Net Freamwork 4.5.2.

The following Packages are necessary:
									nUnit
									ApprovalUtilities
									ApprovalUtilities.Net45

Solution was edited:

1->  Rule and Product class were created
					The Product class represent all properties about an Item 
					Rule => contain all rules about a Product


2-> The Program class has been modified: The BuildProduct method is used to initialize a product list.
The update method initially called was replaced by UpdateQuality2 

3-> The GildedRose class has been modified: The constructor GildedRose and the UpdateQuality method have been marked  as obsolete.
The constructor GildedRose have a list of product as argument and the method UpdateQuality2 has been added

4-> Some unit tests have been added in the GildedRoseTest and ApprovalTest classes.
The ApprovalTest class uses the ThirtyDays2 method with a new set of data which is in the ThirtyDays2.txt file
