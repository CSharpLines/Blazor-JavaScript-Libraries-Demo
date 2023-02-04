function initNotyRazorComponent(text, alertType, position, timeoutInMS) {
	new Noty({
		text: text,
		type: alertType,
		layout: position,
		timeout: timeoutInMS
	}).show();
}