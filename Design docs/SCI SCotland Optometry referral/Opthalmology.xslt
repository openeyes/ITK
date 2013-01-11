<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:pbr="http://www.show.scot.nhs.uk/isd/PBR" xmlns:ref="http://www.show.scot.nhs.uk/isd/Referral" xmlns:gen="http://www.show.scot.nhs.uk/isd/General" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:user="http://www.sci.scot.nhs.uk" exclude-result-prefixes="user msxsl">
	<xsl:output method="html" version="1.0" encoding="iso-8859-1" indent="yes"/>
	<xsl:variable name="default_blank" select="'-'"/>
	<msxsl:script language="JScript" implements-prefix="user"><![CDATA[
		
		function GetMonth(strMonthNumber)
		{
			var strMonth;
			
			switch (strMonthNumber) {
				case "01" :
					strMonth = "Jan";
					break;
				case "02" :
					strMonth = "Feb";
					break;
				case "03" :
					strMonth = "Mar";
					break;
				case "04" :
					strMonth = "Apr";
					break;
				case "05" :
					strMonth = "May";
					break;
				case "06" :
					strMonth = "Jun";
					break;
				case "07" :
					strMonth = "Jul";
					break;
				case "08" :
					strMonth = "Aug";
					break;
				case "09" :
					strMonth = "Sep";
					break;
				case "10" :
					strMonth = "Oct";
					break;
				case "11" :
					strMonth = "Nov";
					break;
				case "12" :
					strMonth = "Dec";
					break; 
				default :
					strMonth = "   ";
			} 
			return(strMonth);
		}
		
		function FormatLineBreaks(strTextToFormat)
		{
			var CrLf = String.fromCharCode(13, 10);
			var Cr = String.fromCharCode(13);
			var Lf = String.fromCharCode(10);
			var NewLine = String.fromCharCode(10);
			
			var strOut = new String();
			var strText = new String(strTextToFormat);
			strOut = strText.replace(NewLine, '<br/>');
			var aCharArray = new Array(NewLine, CrLf, Cr, Lf) 
			
			for( var i = 0; i < 4; i++)
			{
				while(strOut.match(aCharArray[i]))
				{
					strOut = strOut.replace(aCharArray[i], '<br/>');
				}
			}		
			return(strOut); 	    
		}
		
		function IsDate(strValue)
		{
			return(!isNaN(new Date(strValue)));  
		}
		
		function UnambiguousDate(strAmbiguousDate)
		{
			 var dteDate;
			 var strDay, strMonth, strYear, strDate;
			
			 // Garaunteed formats
			 strDate = new String(strAmbiguousDate);
			 strYear = strDate.substring(0,4);  
			 strMonth = strDate.substring(5,7);
			 strDay = strDate.substring(8,10);
			
			 if (IsDate(new Date(strYear,strMonth,strDay)))
			 {
				 return(strDay + "-" + GetMonth(strMonth) + "-" + strYear);
			 }
		}
		
		function IsNumeric(str)
		{
			for (var i=0; i < str.length; i++)
			{
				var ch = str.substring(i, i+1)
				if( ch < "0" || ch>"9" || str.length == null)
				{
					return (false);
				}     
			}
			return (true);
		}
		
		function IsTime(strTimeToCheck)
		{
			var strHour;
			var strMinute;
			var strSecond;
			var lFirstColon;
			var lSecondColon;
			var arrMask = new Array(4);
			var lCount;
			var bValidated;
			var strTime;
			var bIsTime;
			var lValMask;
			
			bIsTime = true;		
			strTime = new String(strTimeToCheck);
			
			arrMask[0] = new String( "9:99");
			arrMask[1] = new String("99:99");
			arrMask[2] = new String("9:99:99");
			arrMask[3] = new String("99:99:99");
			bValidated = false;
			
			for(lCount = 0; lCount < 4;  lCount++)
			{
				  // the mask needs to be the same size as the time
				 if(arrMask[lCount].length == strTime.length)
				 {
					// check the mask
					bValidated = ValidateMask(arrMask[lCount],  strTime);
					if(bValidated)
					{
						lValMask = arrMask[lCount];
						break;
					}
				 }
			}
			
			if(bValidated)
			{
				//based on the mask check that the hours, minutes and seconds are okay (00:00:00-23:59:59)
				
				//get the colons
				lFirstColon = arrMask[lCount].indexOf(":");
				
				if ((lCount == 2) || (lCount == 3))
					lSecondColon = arrMask[lCount].indexOf(":", lFirstColon + 1);
				else
					lSecondColon = 0;
				
				//get the hours
				strHour = strTime.substr(0,lFirstColon);
				bIsTime = ValidateTimeLimit(strHour, 23);
				
				// get the minutes
				strMinute = strTime.substr(lFirstColon + 1, 2);
				bIsTime = ValidateTimeLimit(strMinute, 59);
				
				if(lSecondColon)
				{
					// get the seconds
					strSecond = strTime.substr(lSecondColon + 1, 2);	
					bIsTime = ValidateTimeLimit(strSecond, 59);
				}
			}	
			else
			{
				bIsTime = false;
			}
			return(bIsTime);
		}
		
		function ValidateTimeLimit(strTimeElement, lConstraint)
		{	
		   var bValidateTimeLimit; 
			
		   bValidateTimeLimit = true;
		   if (IsNumeric(strTimeElement))
		   {
			  if (!(strTimeElement <= lConstraint))
				 bValidateTimeLimit = false;
		   }		
		   else
			  bValidateTimeLimit = false;
			
		   return(bValidateTimeLimit);
		}
		
		function ValidateMask(strValidateMask, strValidateTime)
		{
			var bValidated;
			var strMask;
			var strTime
			
			strMask = new String(strValidateMask);
			strTime = new String(strValidateTime);
			
			bValidated = true;
			for(var lCount = 1; lCount < strTime.length + 1; lCount++)
			{  
				if((strMask.substr(lCount, 1) == "9"))  
				{  
					 if(!(IsNumeric(strTime.substr(lCount, 1))))
					 {
						bValidated = false;
						break;
					 }
				}	
				else
				{
					 if (strMask.substr(lCount, 1) == ":")
					 {  
						if(!(strMask.substr(lCount, 1) == strTime.substr(lCount, 1)))
						{
						   bValidated = false;
						   break;
						}
					 }  
				}
			}					
			return(bValidated);
		}
		
		function UnambiguousDateShortTime(p_dteDate, p_strDefault)
		{
			var strTempDate, strTempTime;
			var lSpace;
			var strUnambiguousDateShortTime;
			var strDate = new String(p_dteDate);
			var strDefault = new String(p_strDefault);
			var dteTempDate = new Date(p_dteDate);
			
			strUnambiguousDateShortTime = strDefault;
			
			strDate.replace( "T", " ");
			
			if(strDate.lenth)
			{
				if (IsDate(strDate))
					strUnambiguousDateShortTime = UnambiguousDate(strDate, strDefault) + " " + dteTempDate.getDay() + "-" + dteTempDate.getMonth() + dteTempDate.getYear();
				else
				{
					 lSpace = strDate.indexOf(" ");
					 strTempDate = strDate.substr(0,strDate.indexOf(" "));
					 strTempTime = strDate.substr(strDate.indexOf(" ") + 1);
					 
					 if(IsDate(strTempDate)) 
					 {
						if(IsTime(strTempTime))
						   strUnambiguousDateShortTime = UnambiguousDate(strTempDate, strDefault) + " " 
						   +   dteTempDate.getDay() + "-" + dteTempDate.getMonth() + dteTempDate.getYear();
						else
							strUnambiguousDateShortTime = UnambiguousDate(strTempDate, strDefault) + " " + strTempTime;
					}
				}
			} 	    
			return(strUnambiguousDateShortTime);  
		}
		
	]]></msxsl:script>
	<xsl:template match="ref:ReferralDocument">
		<style>
					body {
						font-family: Tahoma, Arial, Helvetica, sans-serif;
						font-size: 11px;
						margin-top : 2px;
						margin-left : 15px;
						background-color: white;
					}
				
					p {
						margin-bottom : 2px;
						margin-top : 2px;
					}
					
					h1 {
						font-size: 16 px;
						font-weight: bold;
						color : black;
						margin-bottom : 4px;
						margin-top : 4px;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
					}
					
					h2 {
						font-size: 14 px;
						margin-bottom : 3px;
						margin-top : 3px;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
						font-weight: normal;
					}
					
					h3 {
						font-size: 10px ;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
						margin-bottom : 2px;
						margin-top : 2px;
						font-weight : bold;
					}
					
					h4 {
						font-size: 11 px ;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
						margin-bottom : 2px;
						margin-top : 8px;
						text-indent : 32px;
						font-weight : normal;
						text-decoration : underline;
					}
					
					h5 {
						font-size: 11 px ;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
						margin-bottom : 2px;
						margin-top : 8px;
						text-indent : 48px;
						font-weight : normal;
					}
					
					h6 {
						font-size: 10 px ;
						font-family : Verdana, Geneva, Arial, Helvetica, sans-serif;
						margin-bottom : 2px;
						margin-top : 8px;
						text-indent : 60px;
						font-weight : bold;
					}
					
					break {
						page-break-before : always;
					}
				
					a {
						text-decoration: underline;
						color: Navy;
					}
					
					a:hover {
						text-decoration: none;
						color : Red;
					}
					
					table {
						font-size: 11 px ;
					}
					
					.hashed {
						background-color: lightgrey;
						font-weight:bold;
					}
					
					.essential {
						font-weight:bold;
						color:red;
					}
					
					.urgency {
						font-size:20 px;
						color:navy;
					}
					
					.sensitivity{
						font-size:20 px;
						color:navy;
					}
					
					.barcode{
						font-family: SCIBC;
						font-size:20 px;
					}
					
					.barcodeText{
						font-family: Tahoma, Arial, Helvetica, sans-serif;
						font-size: 9px;
					}
					
					.framedCell, .boxedArea
					{
						padding:2px;
						border-spacing:2px;
						border-style:solid;
						border-color:black;
						border-width:1px;
					}
					.boxedArea
					{
						vertical-align:top;
					}
			</style>
		<div style="width:98%;">
			<xsl:apply-templates select="ref:MessageDataRef"/>
		</div>
	</xsl:template>
	<xsl:template match="ref:MessageDataRef">
		<table width="100%" style="border-collapse:collapse;">
			<tr>
				<td width="50%" class="boxedArea" style="border-bottom-width:0px;">
					<xsl:choose>
						<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Cataract')]">
							<b style="font-size:large;"> Direct Referral To Hospital Eye Service</b>
							<br/>
							<b style="font-size:large;"> Cataract</b>
						</xsl:when>
						<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Glaucoma')]">
							<b style="font-size:large;"> Direct Referral To Hospital Eye Service</b>
							<br/>
							<b style="font-size:large;"> Glaucoma</b>
						</xsl:when>
						<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'AMD')]">
							<b style="font-size:large;"> Rapid Access Referral Form</b>
							<br/>
							<b style="font-size:large;color:red;">(WET AMD ONLY)</b>
						</xsl:when>
						<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Paediatric')]">
							<b style="font-size:large;"> Direct Referral To Hospital Eye Service</b>
							<br/>
							<b style="font-size:large;"> Paediatric</b>
						</xsl:when>
						<xsl:otherwise>
							<b style="font-size:large;"> Direct Referral To Hospital Eye Service</b>
							<br/>
							<b style="font-size:large;"> General</b>
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
		</table>
		<table width="100%" style="border-collapse:collapse;">
			<tr>
				<td width="25%" class="boxedArea" style="border-bottom-width:0px;border-right-width:0px;height:40px;"/>
				<td width="50%" class="boxedArea" align="center" style="border-bottom-width:0px;border-right-width:0px;border-left-width:0px;height:40px;">
					<xsl:call-template name="UCPN"/>
				</td>
				<td width="25%" class="boxedArea" align="centre" style="border-bottom-width:0px;border-left-width:0px;height:40px;font-size:15px;">
					<xsl:call-template name="Priority"/>
				</td>
			</tr>
		</table>
		<table width="100%" style="border-collapse:collapse;">
			<tr>
				<td width="50%" class="boxedArea" style="border-bottom-width:0px;">
					<xsl:call-template name="HealthBoardDetails"/>
				</td>
				<td width="50%" class="boxedArea" style="border-bottom-width:0px;">
					<xsl:call-template name="HospitalDetails"/>
				</td>
			</tr>
		</table>
		<table width="100%" style="border-collapse:collapse;">
			<tr valign="top">
				<td width="100%" style="float:left;padding:0px;">
					<xsl:apply-templates select="ref:PatientDemographics" mode="all"/>
				</td>
			</tr>
		</table>
		<xsl:choose>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Cataract')]">
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="PatientHistory_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="CataractDetails"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="LastEyeTest"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="OcularExamination_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="ApplanationTonometry_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="RefractionDetails_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="GPDetails"/>
			</xsl:when>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Glaucoma')]">
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="PatientHistory_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="DiscImages"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="OcularExamination_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="ApplanationTonometry_Glaucoma"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="RefractionDetails_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="GPDetails"/>
				<br/>
			</xsl:when>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'Paediatric')]">
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="PatientHistory_Paediatric"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="OcularExamination_Paediatric"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="PaediatricTests"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="RefractionDetails_Paediatric"/>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="GPDetails"/>
				<br/>
			</xsl:when>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'AMD')]">
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="RefractionDetails_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="ApplanationTonometry_AMD"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="LastEyeTest"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="AMDDetails"/>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="GPDetails_AMD"/>
				<br/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="PatientHistory_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="Diagnosis_Treatment"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="OcularExamination_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="ApplanationTonometry_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef" mode="RefractionDetails_General"/>
				<xsl:apply-templates select="ref:ClinicalDataRef/ref:CurrentClinicalDataRef" mode="GPDetails"/>
				<br/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!-- ref:MessageDataRef -->
	<xsl:template name="UCPN">
		<xsl:choose>
			<xsl:when test="../ref:DocumentData/gen:UniqueCarePathwayNumber">
				<center>
					<div class="barcode">
								*<xsl:value-of select="../ref:DocumentData/gen:UniqueCarePathwayNumber"/>*
							</div>
					<div class="barcodeText">
								Unique Care Pathway Number: <xsl:value-of select="../ref:DocumentData/gen:UniqueCarePathwayNumber"/>
					</div>
				</center>
			</xsl:when>
		</xsl:choose>
	</xsl:template>
	<xsl:template name="Priority">
		<xsl:choose>
			<xsl:when test="./ref:PatientAdministrationRef/ref:ReferralUrgencyValue">
				Urgency of referral &#160;&#160;
				<b>
					&#160;&#160;&#160;&#160;<xsl:value-of select="ref:PatientAdministrationRef/ref:ReferralUrgencyValue"/>
				</b>
			</xsl:when>
		</xsl:choose>
	</xsl:template>
	<xsl:template name="HealthBoardDetails">
		<xsl:choose>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[not (contains(text(), 'AMD'))]">
				<div>
					<b>HEALTH BOARD   </b>
					<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Health Board']/gen:NameValueValue/gen:GenericStringValue"/>
				</div>
			</xsl:when>
		</xsl:choose>
	</xsl:template>
	<xsl:template name="HospitalDetails">
		<xsl:choose>
			<xsl:when test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[not (contains(text(), 'AMD'))]">
				<div>
					<b>HOSPITAL   </b>
					<xsl:value-of select="//ref:ReferralTo/ref:Hospital/gen:OrganisationName"/>
				</div>
			</xsl:when>
		</xsl:choose>
	</xsl:template>
	<xsl:template match="ref:PatientDemographics" mode="all">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="25%" colspan="5" align="left">Patient Surname</th>
					<th class="framedCell" width="25%" colspan="5" align="left">Patient Forename</th>
					<th class="framedCell" width="10%" colspan="2" align="left">Title</th>
					<th class="framedCell" width="40%" colspan="8" align="left">Optometrist Details</th>
				</tr>
				<tr>
					<!-- Patient Surname -->
					<td class="framedCell" colspan="5" align="left" style="height:20px;">
						<xsl:choose>
							<xsl:when test="gen:PatientName[gen:NameType='Current Name']/gen:UnstructuredName">
								<xsl:value-of select="gen:UnstructuredName"/>
							</xsl:when>
							<xsl:when test="gen:PatientName[gen:NameType='Current Name']/gen:StructuredName/gen:FamilyName">
								<xsl:value-of select="gen:PatientName[gen:NameType='Current Name']/gen:StructuredName/gen:FamilyName"/>
							</xsl:when>
							<xsl:otherwise>
								<xsl:value-of select="$default_blank"/>
							</xsl:otherwise>
						</xsl:choose>
					</td>
					<!-- Patient Forename(s) -->
					<td class="framedCell" colspan="5" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="gen:PatientName[gen:NameType='Current Name']/gen:StructuredName/gen:GivenName"/>
								<xsl:for-each select="gen:PatientName[gen:NameType='Current Name']/gen:StructuredName/gen:MiddleName">
									<xsl:text/>
									<xsl:value-of select="."/>
								</xsl:for-each>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<!-- Patient Title -->
					<td class="framedCell" colspan="2" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="gen:PatientName[gen:NameType='Current Name']/gen:StructuredName/gen:Title"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<!-- Optometrist Details -->
					<td class="framedCell" colspan="8" align="left" rowspan="4" style="vertical-align:top;height:75px">
						<xsl:call-template name="OptometristDetails"/>
					</td>
				</tr>
				<tr>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:20px;">DOB</th>
					<!-- Patient DOB -->
					<td class="framedCell" colspan="3" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="date">
								<xsl:value-of select="gen:DateOfBirth"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:20px;">CHI</th>
					<!-- Patient CHI -->
					<td class="framedCell" colspan="5" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="gen:PatientId[gen:IdScheme='CHI']/gen:IdValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:75px;">Address</th>
					<td class="framedCell" colspan="10" align="left" style="vertical-align:top;height:75px;">
						<xsl:apply-templates select="gen:PatientAddress"/>
					</td>
				</tr>
				<tr>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:20px;">Postcode</th>
					<!-- Post Code -->
					<td class="framedCell" colspan="4" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="gen:PatientAddress/gen:PostCode"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:20px;">Tel No</th>
					<!-- Telephone -->
					<td class="framedCell" colspan="4" align="left" style="height:20px;">
						<xsl:choose>
							<xsl:when test="normalize-space(gen:PatientTelecom)">
								<xsl:apply-templates select="gen:PatientTelecom" mode="all"/>
							</xsl:when>
							<xsl:otherwise>
								<xsl:value-of select="$default_blank"/>
							</xsl:otherwise>
						</xsl:choose>
					</td>
				</tr>
				<tr>
					<th class="framedCell" colspan="2" align="left" style="vertical-align:top;height:20px;"> Ref:</th>
					<!-- Reference Number -->
					<td class="framedCell" colspan="10" align="left" style="height:20px;">
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Reference Number']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
					<th class="framedCell" colspan="3" align="left" style="vertical-align:top;height:20px;">Date:</th>
					<!-- Referral Date -->
					<td class="framedCell" colspan="5" align="left" style="height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="date">
								<xsl:value-of select="../ref:PatientAdministrationRef/ref:DateReferred"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="gen:RegisteredGp | ref:ReferringGP">
		<table>
			<tr>
				<td width="15%">Name</td>
				<td width="35%" class="framedCell" colspan="3">
					<xsl:apply-templates select="gen:HcpName"/>
				</td>
				<td class="framedCell" width="45%" rowspan="3" valign="top">
					<xsl:choose>
						<xsl:when test="gen:EmployingOrganisation/gen:OrganisationAddress">
							<xsl:apply-templates select="gen:EmployingOrganisation/gen:OrganisationAddress"/>
						</xsl:when>
						<xsl:otherwise>-</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
			<tr>
				<td>GMC code</td>
				<td class="framedCell" width="10%">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="gen:HcpId[gen:IdScheme='GmcCode' or 'GMC']/gen:IdValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td align="center">GP code</td>
				<td class="framedCell" width="10%">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="gen:HcpId[gen:IdScheme='GpCode']/gen:IdValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
			</tr>
			<tr>
				<td>Practice name</td>
				<td class="framedCell" colspan="3">
					<xsl:choose>
						<xsl:when test="gen:EmployingOrganisation/gen:OrganisationName">
							<xsl:apply-templates select="gen:EmployingOrganisation/gen:OrganisationName"/>
						</xsl:when>
						<xsl:otherwise>-</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
			<tr>
				<td>Practice code</td>
				<td class="framedCell" colspan="3">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="gen:EmployingOrganisation/gen:OrganisationId[gen:IdScheme='PracticeID']/gen:IdValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td>Contact number(s)</td>
			</tr>
			<tr>
				<td colspan="4"/>
				<td class="framedCell">
					<xsl:choose>
						<xsl:when test="normalize-space(gen:EmployingOrganisation/gen:OrganisationTelecom)">
							<xsl:apply-templates select="gen:EmployingOrganisation/gen:OrganisationTelecom" mode="all"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="$default_blank"/>
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
		</table>
	</xsl:template>
	<xsl:template name="OptometristDetails">
		<table style="width:100%;">
			<tr>
				<td>
					<xsl:choose>
						<xsl:when test="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty">
							<xsl:call-template name="ref:ReferringParty"/>
						</xsl:when>
						<xsl:otherwise>
							No referring Optometrist specified
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
		</table>
	</xsl:template>
	<xsl:template name="ref:ReferringParty">
		<!-- Optometrist Name -->
		<p>
			<xsl:value-of select="concat(../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringHcp/gen:HcpName/gen:StructuredName/gen:GivenName, ' ',../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringHcp/gen:HcpName/gen:StructuredName/gen:FamilyName)"/>
		</p>
		<!-- Optometrist Organisation Name -->
		<p>
			<xsl:value-of select="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationName"/>
		</p>
		<!-- Optometrist Organisation Address -->
		<p>
			<xsl:choose>
				<xsl:when test="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationAddress">
					<xsl:apply-templates select="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationAddress"/>
				</xsl:when>
			</xsl:choose>
		</p>
		<!-- Optometrist Organisation Post Code-->
		<p>
			<xsl:choose>
				<xsl:when test="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationAddress/gen:PostCode">
					<xsl:apply-templates select="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationAddress/gen:PostCode"/>
				</xsl:when>
			</xsl:choose>
		</p>
		<!-- Optometrist Oprganisation Telephone -->
		<p>
			<xsl:choose>
				<xsl:when test="normalize-space(../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationTelecom)">
					<xsl:apply-templates select="../ref:PatientAdministrationRef/ref:Referrer/ref:ReferringParty/ref:ReferringOrg/gen:OrganisationTelecom" mode="all"/>
				</xsl:when>
			</xsl:choose>
		</p>
	</xsl:template>
	<xsl:template match="gen:PatientAddress | gen:OrganisationAddress">
		<xsl:choose>
			<xsl:when test="gen:UnstructuredAddress">
				<p>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="gen:UnstructuredAddress"/>
						</xsl:with-param>
					</xsl:call-template>
				</p>
			</xsl:when>
			<xsl:otherwise>
				<p>
					<xsl:value-of select="gen:StructuredAddress/gen:PropertyNumber"/>
				</p>
				<xsl:for-each select="gen:StructuredAddress/gen:AddressLine">
					<p>
						<xsl:value-of select="."/>
					</p>
				</xsl:for-each>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<xsl:template match="gen:PatientTelecom | gen:HcpTelecom | gen:OrganisationTelecom | gen:Telecom" mode="all">
		<p>
			<xsl:choose>
				<xsl:when test="gen:UnstructuredTelecom[not('')]">
					<xsl:value-of select="gen:UnstructuredTelecom"/>
				</xsl:when>
				<xsl:when test="gen:StructuredTelecom[not('')]">
					<xsl:value-of select="gen:StructuredTelecom/gen:TelecomCountry"/>
				(<xsl:value-of select="gen:StructuredTelecom/gen:TelecomArea"/>)
				<xsl:value-of select="gen:StructuredTelecom/gen:TelecomNo"/>
					<xsl:value-of select="gen:StructuredTelecom/gen:TelecomExt"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:text>Not Known</xsl:text>
				</xsl:otherwise>
			</xsl:choose>
		</p>
	</xsl:template>
	<xsl:template match="ref:CurrentClinicalDataRef" mode="PatientHistory_General">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<td class="framedCell" width="50%" colspan="10" rowspan="5" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>Patient History &amp; Details</b>
						<br/>
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Patient History and Details']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">Previous Attendance at HES</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Previous Attendance at HES?']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">If Yes ? Location </th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Previous Attendance at HES?']/gen:NameValueValue/gen:GenericStringValue/text()='Yes'">
							<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='If Yes, Location']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:if>
					</td>
				</tr>
				<tr>
					<td class="framedCell" colspan="10" align="left">
						<b>Armed Forces Personnel, Immediate families and veterans</b>
						<br/>
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Armed Forces Veteran'][gen:NameValueValue/gen:GenericStringValue/text()='true']">
							- Armed Forces Veteran<br/>
						</xsl:if>
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Condition Related to Service'][gen:NameValueValue/gen:GenericStringValue/text()='true']">
							- Condition Related to Service<br/>
						</xsl:if>
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='On Active Service'][gen:NameValueValue/gen:GenericStringValue/text()='true']">
							- On Active Service<br/>
						</xsl:if>
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Immediate Family Member'][gen:NameValueValue/gen:GenericStringValue/text()='true']">
							- Immediate Family Member
						</xsl:if>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">Translator Required</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Translator Required?']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">If Yes ? Language </th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Translator Required?']/gen:NameValueValue/gen:GenericStringValue/text()='Yes'">
							<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='If Yes, Language']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:if>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:CurrentClinicalDataRef" mode="PatientHistory_Paediatric">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<td class="framedCell" width="50%" colspan="10" rowspan="6" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>Patient History &amp; Details</b>
						<br/>
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Patient History and Details']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">Previous Attendance at HES</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Previous Attendance at HES?']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">If Yes ? Location </th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Previous Attendance at HES?']/gen:NameValueValue/gen:GenericStringValue/text()='Yes'">
							<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='If Yes, Location']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:if>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">Armed Forces Personel Immediate Family</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Immediate family']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">Translator Required</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Translator Required?']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">If Yes ? Language </th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:if test="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Translator Required?']/gen:NameValueValue/gen:GenericStringValue/text()='Yes'">
							<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='If Yes, Language']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:if>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="30%" colspan="6" align="left" style="vertical-align:top;height:20px;">Images Attached</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Images Attached']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="Diagnosis_Treatment">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<b>Diagnosis</b>
					</th>
					<td class="framedCell" width="45%" colspan="9" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Diagnosis']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<b>Treatment Instigated</b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Treatment Instigated']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<b>Treatment</b>
					</th>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Treatment']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="DiscImages">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<b>Disc Images</b>
					</th>
					<td class="framedCell" width="40%" colspan="8" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Disc Images']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<b>Family History of Glaucoma</b>
					</th>
					<td class="framedCell" width="40%" colspan="8" align="left" style="border-top-width:0px;vertical-align:top;height:20px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Family History of Glaucoma']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="LastEyeTest">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Date of Last Eye Test </b>
					</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="date">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Date of Last Eye Test ']/gen:NameValueValue/gen:GenericDateValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="40%" colspan="8" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Acuity at Last Eye Test</b>
					</th>
					<th class="framedCell" width="5%" colspan="1" align="right" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Right </b>
					</th>
					<td class="framedCell" width="5%" colspan="1" align="right" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="right" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Left </b>
					</th>
					<td class="framedCell" width="5%" colspan="1" align="right" style="border-left-width:0px;border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="CataractDetails">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-top-width:0px;border-bottom-width:0px;">Lifestyle affected</th>
					<td class="framedCell" width="15%" colspan="3" align="left" style="border-top-width:0px;border-bottom-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Lifestyle affected']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="15%" colspan="1" rowspan="3" align="left" style="border-top-width:0px;vertical-align:top;">AMD Present</th>
					<td class="framedCell" width="25%" colspan="3" rowspan="3" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='AMD Present']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-top-width:0px;border-bottom-width:0px;">Wants surgery (if advised)</th>
					<td class="framedCell" width="15%" colspan="3" align="left" style="border-top-width:0px;border-bottom-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Wants surgery (if advised)']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-top-width:0px;">Cataract Leaflet Given</th>
					<td class="framedCell" width="15%" colspan="3" align="left" style="border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Cataract Leaflet Given']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="AMDDetails">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;"/>
					<th class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;">
						<b>R</b>
					</th>
					<th class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;">
						<b>L</b>
					</th>
				</tr>
				<tr>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<b>Complaint/Symptoms</b>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Complaint/Symptoms Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Complaint/Symptoms Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<b>Duration of Visual Loss</b>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Duration of Vision Loss Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Duration of Vision Loss Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<b>Describe Findings</b>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Describe Findings Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:100px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Describe Findings Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<td class="framedCell" width="30%" colspan="6" align="left" style="border-top-width:0px;vertical-align:top;height:50px">
						<b>Fundus Image (Preferable)</b>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:50px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Fundus Image Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="35%" colspan="7" align="left" style="border-top-width:0px;vertical-align:top;height:50px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Fundus Image Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="OcularExamination_General">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Right</b>
					</th>
					<th class="framedCell" width="60%" colspan="12" align="center" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Ocular Examination - External/Internal</b>
					</th>
					<th class="framedCell" width="20%" colspan="4" align="right" style="border-left-width:0px;border-top-width:0px;">
						<b>Left</b>
					</th>
				</tr>
				<tr>
					<td class="framedCell" width="50%" colspan="10" align="left" style="border-top-width:0px;vertical-align:top;height:200px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Comment Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="50%" colspan="10" align="left" style="border-top-width:0px;vertical-align:top;height:200px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Comment Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="OcularExamination_Paediatric">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Right</b>
					</th>
					<th class="framedCell" width="60%" colspan="12" align="center" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Ocular Examination - dilated </b>
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Dilated']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</th>
					<th class="framedCell" width="20%" colspan="4" align="right" style="border-left-width:0px;border-top-width:0px;">
						<b>Left</b>
					</th>
				</tr>
				<tr>
					<td class="framedCell" width="50%" colspan="10" align="left" style="border-top-width:0px;vertical-align:top;height:200px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Comment Right']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" width="50%" colspan="10" align="left" style="border-top-width:0px;vertical-align:top;height:200px">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Comment Left']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="ApplanationTonometry_Glaucoma">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>Applanation Tonometry</b>
					</th>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>R </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>L </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="10%" colspan="2" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>RAPD </b>
					</th>
					<td class="framedCell" width="15%" colspan="3" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='RAPD']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="10%" colspan="2" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>Fields Attached </b>
					</th>
					<td class="framedCell" width="15%" colspan="3" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Fields Attached']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Time </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='hrs']/gen:NameValueValue/gen:GenericStringValue"/> :
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='mins']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;"/>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-left-width:0px;border-top-width:0px;"/>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="ApplanationTonometry_General">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>Applanation Tonometry</b>
					</th>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>R </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>L </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="10%" colspan="2" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>RAPD </b>
					</th>
					<td class="framedCell" width="15%" colspan="3" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='RAPD']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<th class="framedCell" width="10%" colspan="2" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>Fields Attached </b>
					</th>
					<td class="framedCell" width="15%" colspan="3" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Fields Attached']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Time </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='hrs']/gen:NameValueValue/gen:GenericStringValue"/> :
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='mins']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Applanation </b>
					</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-left-width:0px;border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Applanation']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="ApplanationTonometry_AMD">
		<div>
			<table width="100%" style="border-collapse:collapse;">
				<tr>
					<th class="framedCell" width="20%" colspan="4" align="left" style="border-right-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>Applanation Tonometry</b>
					</th>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>R </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Right']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="5%" colspan="1" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<b>L </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-left-width:0px;border-top-width:0px;border-bottom-width:0px;">
						<xsl:if test="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Left']/gen:NameValueValue/gen:GenericStringValue"/> mmhg
							</xsl:if>
					</td>
					<th class="framedCell" width="10%" colspan="2" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<b>RAPD </b>
					</th>
					<td class="framedCell" width="40%" colspan="8" rowspan="2" align="left" style="border-top-width:0px;vertical-align:top;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='RAPD']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-top-width:0px;">
						<b>Time </b>
					</th>
					<td class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='hrs']/gen:NameValueValue/gen:GenericStringValue"/> :
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='mins']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
					<th class="framedCell" width="10%" colspan="2" align="left" style="border-right-width:0px;border-left-width:0px;border-top-width:0px;">
						<b>Applanation </b>
					</th>
					<td class="framedCell" width="20%" colspan="4" align="left" style="border-left-width:0px;border-top-width:0px;">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Applanation']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="RefractionDetails_General">
		<!--REFRACTION DETAILS-->
		<table style="width:100%;border-collapse:collapse;">
			<colgroup>
				<col style="width:7%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:10%;text-align:center;"/>
				<col style="width:13%;text-align:center;"/>
			</colgroup>
			<tr>
				<th class="framedCell" style="border-top-width:0px">Vision</th>
				<th class="framedCell" style="border-top-width:0px">Sph</th>
				<th class="framedCell" style="border-top-width:0px">Cyl</th>
				<th class="framedCell" style="border-top-width:0px">Axis</th>
				<th class="framedCell" style="border-top-width:0px">Prism</th>
				<th class="framedCell" style="border-top-width:0px">VA</th>
				<th class="framedCell" style="border-top-width:0px">PH VA</th>
				<th class="framedCell" style="border-top-width:0px">Add</th>
				<th class="framedCell" style="border-top-width:0px">NVA</th>
				<th class="framedCell" style="border-top-width:0px">Test Date</th>
			</tr>
			<tr>
				<td class="framedCell">
					<b>R</b>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Prism In/Out']/gen:NameValueValue/gen:GenericStringValue"/>
					&#160;
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Prism']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R PH VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Add']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R NVA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" rowspan="2">
					<xsl:call-template name="format_text">
						<xsl:with-param name="date">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Test Date']/gen:NameValueValue/gen:GenericDateValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
			</tr>
			<tr>
				<td class="framedCell">
					<b>L</b>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Prism In/Out']/gen:NameValueValue/gen:GenericStringValue"/>
					&#160;
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Prism']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L PH VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Add']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L NVA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
			</tr>
			<xsl:if test="/ref:ReferralDocument/ref:DocumentData/gen:DocumentIdentifier/gen:IdValue[contains(text(), 'General')]">
				<tr>
					<td class="framedCell" colspan="8"/>
					<th class="framedCell">
					Images Attached
				</th>
					<td class="framedCell">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Images Attached']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</xsl:if>
		</table>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="RefractionDetails_Paediatric">
		<!--REFRACTION DETAILS-->
		<table style="width:100%;border-collapse:collapse;">
			<colgroup>
				<col style="width:3%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:14%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:9%;text-align:center;"/>
				<col style="width:11%;text-align:center;"/>
			</colgroup>
			<tr>
				<th class="framedCell" rowspan="2" style="border-top-width:0px"/>
				<th class="framedCell" rowspan="2" style="border-top-width:0px">VA</th>
				<th class="framedCell" rowspan="2" style="border-top-width:0px">Test Used <br/>(linear preferred)</th>
				<th class="framedCell" colspan="2" style="border-top-width:0px;border-right-width:0px">Refraction - cycloplegic</th>
				<td class="framedCell" align="left" style="border-top-width:0px;border-left-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Refraction - cycloplegic']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<th class="framedCell" rowspan="2" style="border-top-width:0px">Corrected VA</th>
				<th class="framedCell" colspan="2" style="border-top-width:0px;border-right-width:0px">Glasses prescribed</th>
				<td class="framedCell" align="left" style="border-top-width:0px;border-left-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Glasses Prescribed']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<th class="framedCell" rowspan="2" style="border-top-width:0px">Test Date</th>
			</tr>
			<tr>
				<th class="framedCell" style="border-top-width:0px">Sph</th>
				<th class="framedCell" style="border-top-width:0px">Cyl</th>
				<th class="framedCell" style="border-top-width:0px">Axis</th>
				<th class="framedCell" style="border-top-width:0px">Sph</th>
				<th class="framedCell" style="border-top-width:0px">Cyl</th>
				<th class="framedCell" style="border-top-width:0px">Axis</th>
			</tr>
			<tr>
				<th class="framedCell" style="border-top-width:0px">R</th>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Test Used']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='R Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected R Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" rowspan="2" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="date">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Test Date']/gen:NameValueValue/gen:GenericDateValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
			</tr>
			<tr>
				<th class="framedCell" style="border-top-width:0px">L</th>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Test Used']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='L Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L VA']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L Sph +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L Sph']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L Cyl +/-']/gen:NameValueValue/gen:GenericStringValue"/>
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L Cyl']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
				<td class="framedCell" style="border-top-width:0px">
					<xsl:call-template name="format_text">
						<xsl:with-param name="text">
							<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Corrected L Axis']/gen:NameValueValue/gen:GenericStringValue"/>
						</xsl:with-param>
					</xsl:call-template>
				</td>
			</tr>
		</table>
	</xsl:template>
	<xsl:template match="ref:ClinicalDataRef" mode="PaediatricTests">
		<div>
			<table style="width:100%;border-collapse:collapse;">
				<tr>
					<th class="framedCell" style="width:10%;vertical-align:top;border-top-width:0px;border-right-width:0px;border-bottom-width:0px;" align="left" colspan="2">Amblyoia</th>
					<td class="framedCell" style="width:10%;vertical-align:top;border-top-width:0px;border-left-width:0px;border-bottom-width:0px;" align="left" colspan="2">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Amblyoia']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
					<td class="framedCell" style="width:80%;vertical-align:top;border-top-width:0px;" align="left" colspan="16" rowspan="2">
						<b>Cover test/ stereopsis/ EOM</b>
						<br/>
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Cover test/stereopsis/EOM']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
				<tr>
					<th class="framedCell" style="width:10%;vertical-align:top;border-top-width:0px;border-right-width:0px;" align="left" colspan="2">Squint</th>
					<td class="framedCell" style="width:10%;vertical-align:top;border-top-width:0px;border-left-width:0px;" align="left" colspan="2">
						<xsl:call-template name="format_text">
							<xsl:with-param name="text">
								<xsl:value-of select="./ref:CurrentClinicalDataRef/ref:GenericCurrentClinicalInformation/gen:GenericInformationInstance/gen:NameValuePair[gen:NameValueName/gen:NameId/text()='Squint']/gen:NameValueValue/gen:GenericStringValue"/>
							</xsl:with-param>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:CurrentClinicalDataRef" mode="GPDetails">
		<div>
			<table style="width:100%;border-collapse:collapse;">
				<tr>
					<td style="width:50%;vertical-align:top;border-top-width:0px;" class="framedCell" rowspan="7">
						<b>GP informed of referral?    </b>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Has patients GP been informed?']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
					<td align="left" style="width:10%;vertical-align:top;border-top-width:0px;" class="framedCell">GP Name:</td>
					<td class="framedCell" style="width:40%;vertical-align:top;border-top-width:0px;">
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Name']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
				</tr>
				<tr>
					<td align="left" style="width:10%;vertical-align:top;border-top-width:0px;" class="boxedArea">GP Address:</td>
					<td class="boxedArea" style="border-top-width:0px;">
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Practice Name']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 1']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 2']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 3']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 4']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Postcode']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<xsl:template match="ref:CurrentClinicalDataRef" mode="GPDetails_AMD">
		<div>
			<table style="width:100%;border-collapse:collapse;">
				<tr>
					<td style="width:50%;vertical-align:top;border-top-width:0px;" class="framedCell" rowspan="7">
						<b>GP informed of referral?    </b>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Has patients GP been informed?']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						(Do not send a copy of this letter use separate GP letter for information only)
					</td>
					<td align="left" style="width:10%;vertical-align:top;border-top-width:0px;" class="framedCell">GP Name:</td>
					<td class="framedCell" style="width:40%;vertical-align:top;border-top-width:0px;">
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Name']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
				</tr>
				<tr>
					<td align="left" style="width:10%;vertical-align:top;border-top-width:0px;" class="boxedArea">GP Address:</td>
					<td class="boxedArea" style="border-top-width:0px;">
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Practice Name']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 1']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 2']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 3']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Address Line 4']/gen:NameValueValue/gen:GenericStringValue"/>
						<br/>
						<xsl:value-of select="//ref:NameValuePair[gen:NameValueName/gen:NameId/text()='Postcode']/gen:NameValueValue/gen:GenericStringValue"/>
					</td>
				</tr>
			</table>
			<table style="width:100%;border-collapse:collapse;">
				<tr>
					<td style="width:100%;vertical-align:top;border-top-width:0px;" class="framedCell">
						<b>Patients will be contacted within 48 hours of receipt of this referral letter (Monday to Friday 9am - 5pm).</b>
						<br/>
						<b>Appointments will be sent out within 2 weeks.</b>
					</td>
				</tr>
			</table>
		</div>
	</xsl:template>
	<!-- *********************** FUNCTIONS  ************************ -->
	<xsl:template name="format_text">
		<xsl:param name="text"/>
		<xsl:param name="date"/>
		<xsl:param name="datetime"/>
		<xsl:param name="default" select="$default_blank"/>
		<xsl:choose>
			<xsl:when test="normalize-space($date)">
				<!-- <xsl:value-of select="$date"/> -->
				<xsl:value-of select="user:UnambiguousDate(string($date))"/>
			</xsl:when>
			<xsl:when test="normalize-space($datetime)">
				<xsl:value-of select="$datetime"/>
			</xsl:when>
			<xsl:when test="normalize-space($text)">
				<!-- <xsl:value-of select="$text"/>  -->
				<xsl:value-of disable-output-escaping="yes" select="user:FormatLineBreaks(string($text))"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$default"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<xsl:template name="boolean_to_text">
		<xsl:param name="text"/>
		<xsl:param name="textIfFalse"/>
		<xsl:param name="textIfTrue"/>
		<xsl:variable name="textToLower" select="normalize-space(translate($text, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'))"/>
		<xsl:choose>
			<xsl:when test="$textToLower='false'">
				<xsl:value-of select="$textIfFalse"/>
			</xsl:when>
			<xsl:when test="$textToLower='true'">
				<xsl:value-of select="$textIfTrue"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$default_blank"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<xsl:template name="boolean_to_yes_no">
		<xsl:param name="text"/>
		<xsl:call-template name="boolean_to_text">
			<xsl:with-param name="text" select="$text"/>
			<xsl:with-param name="textIfFalse">No</xsl:with-param>
			<xsl:with-param name="textIfTrue">Yes</xsl:with-param>
		</xsl:call-template>
	</xsl:template>
</xsl:stylesheet>
