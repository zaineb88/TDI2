/*
 *	Formation jQuery
 *	TP 7 : Fonctions
 *  Script pour le mod�le des infobulles
 * 	Inspir� d'un plugin d'Alen Grakalic (http://cssglobe.com/post/1695/easiest-tooltip-and-image-preview-using-jquery)
*/

// Encapsulation :
(function ($) {

	// Au chargement de la page :
	$(document).ready(function(){
	
			// Initialisation : position "relative" sur <body> pour pouvoir d�placer l'infobulle
			$("body").css("position","relative") ;
			
			// Initialisation : cr�ation de l'infobulle
			var $infobulle = $("<p></p>")
			
			// identifiant de l'infobulle
			$infobulle.attr("id","mytooltip") ;
			
			// Style de l'infobulle
			$infobulle.css({
				position:"absolute",
				opacity:0.7,
				background:"#493e3b",
				color:"#fff",
				padding:"5px",
				margin:"0px",
				border:"2px solid #362f2d"
			}) ;
			
			// Variable globale pour stocker le titre des infobulles
			var title = "" ;

			// Pour chaque lien du menu des onglets...
			$(".onglets a").each(function(){
				
				// lien courant :
				var $a = $(this) ;
				
				// Evenements "la souris arrive sur le lien" et "la souris quitte le lien"
				$a.hover(
					// Quand la souris arrive sur le lien on fait appara�tre l'infobulle
					// L'infobulle contient l'attribut "titre" du lien
					function(e){								  
						title = $a.attr("title");
						$a.attr("title","") ;
						$infobulle
							.hide()
							.text(title)
							.appendTo("body")
							//  position de l'infobulle par rapport au curseur (ordonn�e)
							.css("top",(e.pageY + 20) + "px")
							// position de l'infobulle par rapport au curseur (abscisse)
							.css("left",(e.pageX + 20) + "px")
							// L'infobulle appara�t 
							.fadeIn(50);		
					},
					function(){
						// Quand la souris quitte le lien on fait dispara�tre l'infobulle
						// L'attribut "titre" du lien prend le contenu de ce qui �tait dans l'infobulle
						$a.attr("title",title) ;		
						$infobulle.detach() ;
					}
				);
				
				// Evenement "la souris se d�place au dessus du lien
				// On fait bouger l'infobulle en m�me temps que le lien
				$a.mousemove(function(e){
					$infobulle
						//  position de l'infobulle par rapport au curseur (ordonn�e)
						.css("top",(e.pageY + 20) + "px")
						// position de l'infobulle par rapport au curseur (abscisse)
						.css("left",(e.pageX + 20) + "px");
				});				
			});

	}); // Fin des instructions envoy�es au chargement de la page
	
})(jQuery); // Fin de l'encapsulation
