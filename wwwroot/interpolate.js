function initNotyRazorComponent(text, alertType, position, timeoutInMS) {
	new Noty({
		text: text,
		type: alertType,
		layout: position,
		timeout: timeoutInMS
	}).show();
}

function initQuillRazorComponent(dotnetInstance, editorElement, theme, placeholder, isReadOnly, oldContent) {

	var options = {
		theme: theme,
		readOnly: isReadOnly,
		placeholder: placeholder
	};

	var editor = new Quill(editorElement, options);

	try {
		var parsedJson = JSON.parse(oldContent);
		editor.setContents(parsedJson);
	}
	catch (e) {
		editor.setText(oldContent);
	}

	editor.on('text-change', function () {
		// get the contents of our editor
		// stringify it
		// send it to out dotnet instance to save
		var jsonContents = editor.getContents();
		var contents = JSON.stringify(jsonContents);
		dotnetInstance.invokeMethodAsync('TextWasChanged', contents);
	});
}