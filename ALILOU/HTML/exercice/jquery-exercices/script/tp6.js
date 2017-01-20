/*
 *	Formation jQuery
 *	TP 4 bis : Plugins
*/

// Encapsulation :
(function ($) {

	// Au chargement de la page :	
	$(document).ready(function() {

		/*	
			DEMO
		*/
		
		// Echec du chargement
		// $("<div></div>").load("/not-here.php",function(data, status) {
			// if (status == "error") alert("Erreur !") ;
			// else alert(data)  ;
        // }); 
		
		/*	
			EXEMPLE
			Chargement d'un tableau
		*/
		
		// Bouton cliquable
		var $exemple = $("input#exemple") ;
		
		// Adresse du fichier charg�
		var fichierExemple = "xml/reg43.xml" ;
		
		// Emplacement du tableau
		var $conteneurTableau = $("#tableau") ;
		
		// �v�nement clique
		$exemple.click(function(){
			
			// M�thode .load() : charge directement le contenu du fichier dans l'objet auquel la m�thode s'applique
			$conteneurTableau.load(fichierExemple,function(data,status){
			
				// Param�tre data : contenu du fichier charg�
				// alert(data) ;
				// Param�tre status : vaut erreur si le fichier n'a pas �t� charg�
				if(status=="error") {
				
					// Message d'erreur
					$conteneurTableau.html("<p>Impossible de charger le fichier "+fichierExemple+"</p>") ;
					
					// Interruption du script
					return ;
				}
				// Message ajout� dans le tableau
				$conteneurTableau.append("<p>Charg&eacute; &agrave; partir du fichier "+fichierExemple+"</p>") ;
				
			});
		});
		
		/*	
			EXERCICE 1
			Affichage du tableau correspondant � l'option s�lectionn�e quand on clique sur le bouton �voir les d�partements�.
			Les addresses des fichiers des tableaux sont dans les attributs value des options.
			Le bouton cliquable se retrouve gr�ce � l'identifiant valide et la liste de s�lection avec l'identifiant regions.
		*/	
		
		/*	
			EXERCICE 2
			Recr�er la liste de s�lection � partir du fichier xml/regions.xml. 
			Les options g�n�r�es � partir du xml auront comme attribut value le code de la r�gion (regid).
		*/
		
		/*
			EXERCICE 3
			Charger le fichier xml/departements.xml.
			Quand on clique sur le bouton �voir les d�partements�, un tableau est g�n�r� avec uniquement les d�partements de la r�gion s�lectionn�e.
		*/
		
	}); // Fin des instructions envoy�es au chargement de la page
	
})(jQuery); // Fin de l'encapsulation
