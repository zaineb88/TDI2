<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html"/>
    <xsl:template match="/livre">
        <html>
            <head>
                <title> Table de matiere</title>
            </head>
            <body>
              <h2>Liste des auteurs </h2> 
               <table border="1">
                   <tr bgcolor="gray"><td>Nom</td><td>Preom</td></tr>
                   <xsl:for-each select="auteurs/auteur">
                       <tr ><td><xsl:value-of select="@nom"/></td><td><xsl:value-of select="attribute::prenom"/></td></tr>   
                   </xsl:for-each>
               </table>
            </body>
            </html>
    </xsl:template>
</xsl:stylesheet>
