<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  
  <xsl:output method="text" encoding="UTF-8"/>
  <xsl:param name="newline" />

  <xsl:template match="body/element">
    <xsl:value-of select="./text()"/>
    <xsl:value-of select="$newline"/>
  </xsl:template>

</xsl:stylesheet>
