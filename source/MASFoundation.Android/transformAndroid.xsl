<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output omit-xml-declaration="yes"
    indent="yes"
    method="xml"/>
  <xsl:strip-space elements="*"/>

  <!-- Identity Transform -->
  <xsl:template match="@*|node()">
    <xsl:copy>
      <xsl:apply-templates select="@*|node()"/>
    </xsl:copy>
  </xsl:template>

  <!-- Contents of remarks to summary -->
  <xsl:template match="/doc/members/member/summary">
    <xsl:copy>
      <xsl:apply-templates select="../remarks/node()"/>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>
