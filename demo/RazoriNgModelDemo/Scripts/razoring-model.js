// Adds angular attributes to scaffolded Razor forms.
var setupRazoringModel = function () {
    var modelContainers = $("[data-ng-model-name]");

    modelContainers.each(function () {
        var ngModelName = $(this).data("ngModelName");
        var formInputs = $(this).find("input:not('[name='__RequestVerificationToken']')");

        formInputs.each(function () {
            var modelBinding = ngModelName + "." + $(this).attr("Name");

            $(this).attr("ng-model", modelBinding);
        });
    });
};