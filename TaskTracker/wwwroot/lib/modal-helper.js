/* Implement one bootstrap modal across the entire application.
 * The launchModal() function takes a set of arguments and sets
 * all modals content as well as all pertinent configuration and styling settings.
 */

var modalPopup = $('#modalPopup');

function openModal(content, title, color, width, isDismissable) {
    var modalOptions = {
        cardColor: color,
        modalWidth: width,
        modalTitle: title,
        modalBodyContent: content,
        isDismissable: isDismissable
    }
    launchModal(modalOptions);
}

function closeModal() {
    modalPopup.modal('hide');
}

function launchModal(options) {
    setModalCardColor(options.color);
    setModalWidth(options.modalWidth);
    setModalTitle(options.modalTitle);
    setModalBody(options.modalBodyContent);

    var boostrstrapModalOptions = setModalCloseButton(options.isDismissable);

    modalPopup.modal(boostrstrapModalOptions);
}

function setModalCardColor(cardColor) {
    if (cardColor === undefined) {
        cardColor = 'primary';
    }

    var cardHeader = modalPopup.find('.modal-helper > .card-header');
    cardHeader.removeClass('card-header-primary card-header-info card-header-success card-header-danger card-header-warning card-header-default');
    var cardHeaderClass = 'card-header-' + cardColor;
    cardHeader.addClass(cardHeaderClass);
}

function setModalWidth(width) {
    if (width === undefined) {
        width = 'medium';
    }

    var modalDialog = modalPopup.find('.modal-dialog');
    modalDialog.removeClass('modal-lg modal-sm');

    if (width === 'large')
        modalDialog.addClass('modal-lg');

    if (width === 'small')
        modalDialog.addClass('modal-sm');
}

function setModalTitle(title) {
    if (title === undefined) {
        title = '';
    }
    var modalTitleDiv = modalPopup.find('.modal-title');
    modalTitleDiv.html(title);
}

function setModalBody(content) {
    if (content === undefined) {
        content = '';
    }
    var modalBodyDiv = modalPopup.find('.modal-body');
    modalBodyDiv.html(content);
}

function setModalCloseButton(isDissmissable) {
    var bootstrapModalOptions = {};
    if (isDissmissable === undefined || isDissmissable) {
        $('#modalPopupCloseButton').show();
    }
    else {
        $('#modalPopupCloseButton').hide();
        bootstrapModalOptions.backdrop = 'static';
        bootstrapModalOptions.keyboard = false;
    }

    return bootstrapModalOptions;
}

function showErrorModal(errorMessage) {
    if (errorMessage === undefined || errorMessage == null || errorMessage == '') {
        errorMessage = 'Error.';
    }

    var modalOptions = {
        cardColor: 'danger',
        modalTitle: 'There was an error.',
        modalBodyContent: '<p class="text-center">' + errorMessage + '</p>'
    }
    launchModal(modalOptions);
}

function showInformationMessage(informationMessage, title) {
    if (title === undefined) {
        title = 'Clarification';
    }
    var modalOptions = {
        cardColor: 'info',
        modalTitle: title,
        modalBodyContent: '<p class="text-center">' + informationMessage + '</p>'
    }
    launchModal(modalOptions);
}

function centerText(text) {
    return '<p class="text-center">' + text + '</p>';
}