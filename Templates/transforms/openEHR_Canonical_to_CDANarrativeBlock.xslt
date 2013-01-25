<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="2.0" xmlns:oe="http://schemas.openehr.org/v1" xmlns:hl7="urn:hl7-org:v3" xmlns:npfitlc="NPFIT:HL7:Localisation" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">


  <!-- Specify output, create matches for unwanted top-level elements -->
<!--  <xsl:output encoding="iso-8859-1" doctype-public="-//W3C//DTD XHTML 1.0 Strict//EN"
    doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" indent="yes"/>-->
	
	<xsl:template match="oe:composition">
		<section classCode="DOCSECT" moodCode="EVN">
			<xsl:call-template name="template_Section1" />
			<xsl:call-template name="idWithEmptyUuid" />
			<xsl:call-template name="title" />
			<xsl:apply-templates select="oe:composer" />
			<xsl:apply-templates select="oe:context" />
			<xsl:apply-templates select="oe:content" />
		</section>
	</xsl:template>
<!--
    <xsl:template match="oe:archetype_details">
    	<xsl:call-template name="suppress" />
    </xsl:template>

    <xsl:template match="oe:language">
    	<xsl:call-template name="suppress" />
    </xsl:template>

    <xsl:template match="oe:territory">
    	<xsl:call-template name="suppress" />
    </xsl:template>

    <xsl:template match="oe:category">
    	<xsl:call-template name="suppress" />
    </xsl:template>
-->
	
	<xsl:template match="oe:composer">
		<text>
			<content>Reported by: <xsl:value-of select="oe:name" />
			</content>
		</text>
	</xsl:template>
	
	<xsl:template match="oe:context">
		<component typeCode="COMP" contextConductionInd="true">
			<xsl:call-template name="template_Component1" />
			<section classCode="DOCSECT" moodCode="EVN">
				<xsl:call-template name="template_Section2" />
				<xsl:call-template name="idWithEmptyUuid" />
				<xsl:call-template name="contextBody" />
			</section>
		</component>
	</xsl:template>
	<xsl:template name="contextBody">
		<text>
			<content>Location: <xsl:value-of select="oe:location" />, <xsl:value-of select="oe:health_care_facility/oe:name" />
			</content>
		</text>
	</xsl:template>
	
	<xsl:template match="oe:content[@xsi:type='SECTION']">
		<component typeCode="COMP" contextConductionInd="true">
			<xsl:call-template name="template_Component1" />
			<section classCode="DOCSECT" moodCode="EVN">
				<xsl:call-template name="template_Section2" />
				<xsl:call-template name="idWithEmptyUuid" />
				<xsl:call-template name="sectionBody" />
			</section>
		</component>
	</xsl:template>
	<xsl:template name="sectionBody">
		<xsl:call-template name="title" />
		<xsl:apply-templates select="oe:items" />
	</xsl:template>
	
	
	<xsl:template match="oe:items[@xsi:type='OBSERVATION']">
		<!-- TODO: Determine nest level automatically -->
		<component typeCode="COMP" contextConductionInd="true">
			<xsl:call-template name="template_Component2" />
			<section classCode="DOCSECT" moodCode="EVN">
				<xsl:call-template name="template_Section3" />
				<xsl:call-template name="idWithEmptyUuid" />
				<xsl:call-template name="observationBody" />
			</section>
		</component>
	</xsl:template>
	<xsl:template name="observationBody">
		<xsl:call-template name="title" />
		<xsl:apply-templates select="oe:protocol" />
		<xsl:apply-templates select="oe:data" />
	</xsl:template>
	
	<xsl:template match="oe:items[@xsi:type='ELEMENT']">
		<!-- TODO: Determine nest level automatically -->
		<component typeCode="COMP" contextConductionInd="true">
			<xsl:call-template name="template_Component3" />
			<section classCode="DOCSECT" moodCode="EVN">
				<xsl:call-template name="template_Section4" />
				<xsl:call-template name="idWithEmptyUuid" />
				<xsl:call-template name="elementBody" />
			</section>
		</component>
	</xsl:template>
	<xsl:template name="elementBody">
		<xsl:call-template name="title" />
		<text>
			<content>
				<xsl:value-of select="oe:value/oe:value" />
			</content>
		</text>
	</xsl:template>
	
	<xsl:template match="oe:protocol[@xsi:type='ITEM_TREE']">
		<xsl:apply-templates select="oe:items" />
	</xsl:template>
	
	<xsl:template match="oe:data">
		<!--<text>Date: <xsl:value-of select="oe:origin/oe:value" /></text>-->
		<xsl:for-each select="oe:events[@xsi:type='POINT_EVENT']">
			<!--<text>Date/Time: <xsl:value-of select="oe:time/oe:value" /></text>-->
			<xsl:for-each select="oe:data/oe:items">
				<!-- TODO: Determine nest level automatically -->
				<component typeCode="COMP" contextConductionInd="true">
					<xsl:call-template name="template_Component3" />
					<section classCode="DOCSECT" moodCode="EVN">
						<xsl:call-template name="template_Section4" />
						<xsl:call-template name="idWithEmptyUuid" />
						<xsl:if test="@xsi:type='CLUSTER'">					
							<xsl:call-template name="title" />
							<text>
								<list listType="ordered">
									<xsl:for-each select="oe:items[@xsi:type='ELEMENT']">
										<item>
											<content>
												<xsl:call-template name="element" />
											</content>
										</item>
									</xsl:for-each>
								</list>
							</text>
						</xsl:if>
						<xsl:if test="@xsi:type='ELEMENT'">
							<text>
											<content>
								<xsl:call-template name="element" />
											</content>
							</text>
						</xsl:if>
					</section>
				</component>
			</xsl:for-each>
		</xsl:for-each>
	</xsl:template>
	
	<!-- Common elements -->
	<xsl:template name="title">
		<title>
			<xsl:value-of select="oe:name/oe:value" />
		</title>
	</xsl:template>
	<xsl:template name="element">
		<xsl:value-of select="oe:name/oe:value" />
		<xsl:if test="oe:value[@xsi:type='DV_QUANTITY']">
			<xsl:text> = </xsl:text>
			<xsl:value-of select="oe:value/oe:magnitude" />
			<xsl:text> </xsl:text>
			<xsl:value-of select="oe:value/oe:units" />
		</xsl:if>

		<xsl:if test="oe:value[@xsi:type='DV_CODEDTEXT']">
			<xsl:text> = </xsl:text>
			<xsl:value-of select="oe:value/oe:value" />
		</xsl:if>
		
		<xsl:if test="oe:value[@xsi:type='DV_TEXT']">
			<xsl:text>: </xsl:text>
			<xsl:value-of select="oe:value/oe:value" />
		</xsl:if>
	</xsl:template>
		
	<!-- Fixed elements -->
	<xsl:template name="template_Section1">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#Section1"/>
	</xsl:template>
	<xsl:template name="template_Section2">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#section2"/>
	</xsl:template>
	<xsl:template name="template_Section3">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#section3"/>
	</xsl:template>
	<xsl:template name="template_Section4">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#section4"/>
	</xsl:template>
	<xsl:template name="template_Section5">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#section5"/>
	</xsl:template>
	<xsl:template name="template_Section6">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#section6"/>
	</xsl:template>
		
	<xsl:template name="template_Component1">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#component1"/>
	</xsl:template>
	<xsl:template name="template_Component2">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#component2"/>
	</xsl:template>
	<xsl:template name="template_Component3">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#component3"/>
	</xsl:template>
	<xsl:template name="template_Component4">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#component4"/>
	</xsl:template>
	<xsl:template name="template_Component5">
		<templateId root="2.16.840.1.113883.2.1.3.2.4.18.2" extension="COCD_TP146229GB01#component5"/>
	</xsl:template>
		
	<xsl:template name="idWithEmptyUuid">
		<id root="00000000-0000-0000-0000-000000000000"/>
	</xsl:template>
	<xsl:template name="suppress" />
</xsl:stylesheet>

