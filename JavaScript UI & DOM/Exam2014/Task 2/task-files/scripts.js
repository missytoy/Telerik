$.fn.gallery = function (cols) {

    //   var $gallery = this;
    //  $gallery.addClass('gallery');

    var $gallery = $(this).addClass('gallery'),
        columns = cols || 4;

    var $imageContainer = $gallery.find('.image-container');

    $imageContainer.each(function (index, domElement) {

        if (index % columns == 0) {
            $(domElement).addClass('clearfix');
        }
    });

    $gallery.on('click', '.image-container', onImageClick);

    $gallery
        .find(".current-image")
        .empty()
        .on('click', currentImageClick);

    $gallery
        .find(".previous-image")
        .empty()
        .on('click', previousImageClick);

    $gallery
        .find(".next-image")
        .empty()
        .on('click', nextImageClick);

    function onImageClick() {
        var $clickedElement = $(this);
        var $currentImage = $clickedElement.children().clone(),
            $previousImage,
            $nextImage;

        if ($clickedElement.is($clickedElement.parent().children().first())) {
            $previousImage = $clickedElement.parent().children().last().children().clone();
        }
        else {
            $previousImage = $clickedElement.prev().children().clone();
        }

        if ($clickedElement.is($clickedElement.parent().children().last())) {
            $nextImage = $clickedElement.parent().children().first().children().clone();
        }
        else {
            $nextImage = $clickedElement.next().children().clone();
        }

        $gallery.find(".gallery-list").addClass('blurred');
        $gallery.off('click', '.image-container', onImageClick);

        $gallery.find(".current-image").empty();
        $gallery.find(".previous-image").empty();
        $gallery.find(".next-image").empty();

        $gallery.find(".current-image").html($currentImage);
        $gallery.find(".previous-image").html($previousImage);
        $gallery.find(".next-image").html($nextImage);
    }

    function currentImageClick() {
        $gallery.on('click', '.image-container', onImageClick);
        $gallery.find(".gallery-list").removeClass('blurred');

        $gallery.find(".current-image").empty();
        $gallery.find(".previous-image").empty();
        $gallery.find(".next-image").empty();
    }

    function previousImageClick() {
        var $this = $(this),
            $newCurrent = $this.children().clone(),
            $newNext = $gallery.find(".current-image").children().clone(),
            $currentDataInfo = $newCurrent.attr('data-info'),
            $oldPrevious,
            $newPrevious;

        $gallery.find(".current-image").empty();
        $gallery.find(".previous-image").empty();
        $gallery.find(".next-image").empty();

        $gallery.find(".current-image").html($newCurrent);
        $gallery.find(".next-image").html($newNext);


        $oldPrevious = $gallery
            .find('.image-container')
            .find("[data-info='" + parseInt($currentDataInfo, 10) + "']").parent();

        if ($oldPrevious.is($gallery.find('.gallery-list').children().first())) {
            $newPrevious = $oldPrevious.parent().children().last().children().clone();
        } else {
            $newPrevious = $oldPrevious.prev().children().clone();
        }

        $gallery.find(".previous-image").html($newPrevious);
    }

    function nextImageClick() {
        var $this = $(this),
            $newCurrent = $this.children().clone(),
            $newPrevious = $gallery.find(".current-image").children().clone(),
            $currentDataInfo = $newCurrent.attr('data-info'),
            $oldNext,
            $newNext;

        $gallery.find(".current-image").empty();
        $gallery.find(".previous-image").empty();
        $gallery.find(".next-image").empty();

        $gallery.find(".current-image").html($newCurrent);
        $gallery.find(".previous-image").html($newPrevious);

        $oldNext = $gallery
            .find('.image-container')
            .find("[data-info='" + $currentDataInfo + "']").parent();

        if ($oldNext.is($gallery.find('.gallery-list').children().last())) {
            $newNext = $oldNext.parent().children().first().children().clone();
        } else {
            $newNext = $oldNext.next().children().clone();
        }

        $gallery.find(".next-image").html($newNext);
    }

    return this;
};