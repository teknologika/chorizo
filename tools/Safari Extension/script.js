$(document).ready(function() 
{
	$('#process-page').on('click',function()
	{
		processPage();
	});
});


function processPage()
{
	// list of controls
	var controls = new Array();

	/*  links */
	$('a').each(function() {
    	//console.log($(this).attr('href'));
    	var control = GetControlIdentity($(this),'link');
    	controls.push(control);
	});


	console.log('Valid Controls');
	for (var i = controls.length - 1; i >= 0; i--)
	{
		if (controls[i].isValid)
		{
			GenerateCSControlLine(controls[i]);
		}
	};



	console.log('InValid Controls');
	for (var i = controls.length - 1; i >= 0; i--)
	{
		if (!controls[i].isValid)
		{
			GenerateCSControlLine(controls[i]);
		}
	};
}

function generateName(controlType, text )
{
	var controlName = RemoveDollarSign(text);
	controlName = $.trim(controlName);
	controlName = ToCamelCase(controlName);

	// TODO: check and don't add the control type if it already is present

	if (controlType == 'link')
	{
		controlType = 'lnk';
	}
	return controlType + controlName;

}

function GetControlForElementUsingAttribute(attribute, element, controlType)
{
	var control = {Name:"test", Type:controlType, Key:"null", Value:"null", isValid:false};
    control.Name = generateName(controlType,$(element).attr(attribute).trim());
    control.Type = controlType;
    control.Key = attribute;
    control.Value = $(element).attr(attribute).trim();
    control.isValid = IsValidName(control.Name);
    return control;
}

function GetControlIdentity(element, controlType)
{
	/* Retrieve the identification attribute detail of the element with the following priority:
   "id", "name", "value", "alt", "custom", "for", "index", "src", "href", "style", "text", "title", "url" */

	var control = {Name:null, Type:controlType, Key:null, Value:null, isValid:false};

    //console.log($(element));
    if ($(element).attr('id'))
    {
    	control = GetControlForElementUsingAttribute('id', element, controlType);
    }
    else if ($(element).attr('name'))
    {
		control = GetControlForElementUsingAttribute('name', element, controlType);
    }
    else if ($(element).attr('value'))
    {
		control = GetControlForElementUsingAttribute('value', element, controlType);
    }
    else if ($(element).attr('alt'))
    {
		control = GetControlForElementUsingAttribute('alt', element, controlType);
    }
    else if ($(element).attr('custom'))
    {
		control = GetControlForElementUsingAttribute('custom', element, controlType);
    }
    else if ($(element).attr('index'))
    {
		control = GetControlForElementUsingAttribute('index', element, controlType);
    }
    else if ($(element).attr('src'))
    {
		control = GetControlForElementUsingAttribute('src', element, controlType);
    }
    else if ($(element).attr('href'))
    {
		control = GetControlForElementUsingAttribute('href', element, controlType);
    }
    else if ($(element).attr('style'))
    {
		control = GetControlForElementUsingAttribute('style', element, controlType);
    }
    else if ($(element).attr('style'))
    {
		control = GetControlForElementUsingAttribute('style', element, controlType);
    }
    else if ($(element).text())
    {
	
   		control.Name = generateName(controlType,$(element).text().trim());
    	control.Type = controlType;
    	control.Key = 'text';
    	control.Value = $(element).text();
    	control.isValid = IsValidName(control.Name);
    }
    else if ($(element).attr('title'))
    {
		control = GetControlForElementUsingAttribute('title', element, controlType);
    }
    else if ($(element).attr('url'))
    {
		control = GetControlForElementUsingAttribute('url', element, controlType);
    }
    else
    {
    	control = null;
    }	
    return control;
}


function GenerateCSControlLine(control)
{
	/*
 		this function expects a control object as follows: 
 		var control = {Name:"btnQ", Type:"btn", Key:"id", Value:"Q"};
 	*/
	var line = [];
	line.push("       public static string ",
	ToPascalCase(control.Name) + ' = "',
	'type=' + control.Type + ';',
	control.Key + '=' + control.Value + '";');


	console.log(line.join(''))
}

function ToPascalCase(str)
{

	var result;
	// If there are no spaces, only touch the first letter then return the string
	if(str.indexOf(' ') === -1)
	{
  		result = str;
	}
	else
	{
		// lowercase the string
		str = str.toLowerCase();

		// this uppercases the first letter of all words, and then removes whitespace
    	result = str.replace(/(?:^|\s)\w/g, function(match)
    	{
        	return $.trim(match.toUpperCase());
    	});
    }

    // lowercase the first letter of the first string
    return result.charAt(0).toLowerCase() + result.substring(1);
}

function ToCamelCase(str)
{
	// If there are no spaces, only touch the first letter then return the string
	if(str.indexOf(' ') === -1)
	{
  		result = str;
	}
	else
	{
		// lowercase the string
		str = str.toLowerCase();

		// this uppercases the first letter of all words, and then removes whitespace
    	result = str.replace(/(?:^|\s)\w/g, function(match)
    	{
        	return $.trim(match.toUpperCase());
    	});
    }

    // lowercase the first letter of the first string
    return result.charAt(0).toUpperCase() + result.substring(1);
}

function RemoveDollarSign(str)
{
	return str.replace(/\$/g , "");
}

function ReplaceUnderscoreWithSpace(str)
{
	return str.replace(/_/g , " ");
}

function IsValidName(str)
{
    /* The following regex is representing the valid character types
       for the control variable name

			/^   - Start of string
			A-Z  - Uppercase letters
			a-z  - Lowercase letters
			0-9  - numbers
			'_ ' - underscore and space
			+    - More than one 
			$/   - End of string
	*/

	if (str.match(/^[A-Za-z0-9_ ]+$/)) {
 		return true;	
	}
	return false;
}

           

