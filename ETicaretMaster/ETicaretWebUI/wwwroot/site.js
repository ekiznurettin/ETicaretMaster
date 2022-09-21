$(function () {
    $("#loaderbody").addClass('hide');

    $(document).bind('ajaxStart', function () {
        $("#loaderbody").removeClass('hide');
    }).bind('ajaxStop', function () {
        $("#loaderbody").addClass('hide');
        //unBlockUi js
    });
});
showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal("show");
        }
    })
}



JQueryAjaxPostPersonelSorgula = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    GridOlustur();                }
                else
                $.notify('Kayıt Bulunamadı.Kriterleriniz kontrol ediniz!!', { globalPosition: 'top center', className: 'success' });
            },
            error: function (err) {
                console.log(err);
            }
        })

    } catch (e) {
        console.log(e);
    }
    //to perevent default form submit event
    return false;
}
showInPopupPersonel = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#modalFull .modal-body").html(res);
            $("#modalFull .modal-title").html(title);
            $("#modalFull").modal("show");
        }

    })
}

JQueryAjaxPostPersonel = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#modalFull .modal-body").html('');
                    $("#modalFull .modal-title").html('');
                    $("#modalFull").modal("hide");
                    GridOlustur();
                    $.notify('Kayıt İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                }
                else
                    $("#modalFull .panel-body").html(res.html);
            },
            error: function (err) {
                console.log(err);
            }
        })

    } catch (e) {
        console.log(e);
    }
    //to perevent default form submit event
    return false;
}

JQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $("#form-modal").modal("hide");
                  //  GridOlustur();
                    $.notify('Kayıt İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                }
                else {
                    $("#form-modal .modal-body").html(res.html);
                }
            },
            error: function (err) {
                console.log(err);
            }
        })

    } catch (e) {
        console.log(e);
    }
    //to perevent default form submit event
    return false;
}

JQueryAjaxDelete = form => {
    if (confirm("Silmek istediğinize emin misiz?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $("#view-all").html(res.html);
                        GridOlustur();
                        $.notify('Silme İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            })

        } catch (e) {
            console.log(e);
        }
    }
    //to perevent default form submit event
    return false;
}
JQueryAjaxYayinla = form => {
    if (confirm("Yayınlamak istediğinize emin misiz?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $("#view-all").html(res.html);
                        GridOlustur();
                        $.notify('Yayınlama İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            })

        } catch (e) {
            console.log(e);
        }
    }
    //to perevent default form submit event
    return false;
}
JQueryAjaxYayindanKalir = form => {
    if (confirm("Yayından Kaldırmak istediğinize emin misiz?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $("#view-all").html(res.html);
                        GridOlustur();
                        $.notify('Yayından Kaldırma İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            })

        } catch (e) {
            console.log(e);
        }
    }
    //to perevent default form submit event
    return false;
}

JQueryAjaxPersonelOnayla = form => {
    if (confirm("Personelin pasif sebebini onaylamak istediğinize emin misiz?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $("#view-all").html(res.html);
                        GridOlustur();
                        $.notify('Onaylama İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            })

        } catch (e) {
            console.log(e);
        }
    }
    //to perevent default form submit event
    return false;
}

JQueryAjaxPersonelReddet = form => {
    if (confirm("Personelin pasif sebebini reddetmek istediğinize emin misiz?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $("#view-all").html(res.html);
                        GridOlustur();
                        $.notify('İptal İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            })

        } catch (e) {
            console.log(e);
        }
    }
    //to perevent default form submit event
    return false;
}

JQueryAjaxDeletePost = (e) => {
    if (confirm("Silmek istediğinize emin misiz?")) {
        var x = e.dataset;
        $.ajax({
            url: x.url
            , type: 'POST'
            , data: { id: x.id },
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    GridOlustur();
                    $.notify('Silme İşlemi Başarılı.', { globalPosition: 'top center', className: 'success' });
                }
            },
            error: function (err) {
                debugger
                console.log(err);
            }
        });
    }
    return false;
}

function GridOlustur() {
    $('.table').DataTable({
        language: {
            url: "/vendor/datatables/turkce.json"
        },
        dom: 'Bfrtip',
        lengthMenu: [
            [10, 25, 50, -1],
            ['10 kayıt', '25 kayıt', '50 kayıt', 'Tümü']
        ],
        buttons: [
            'pageLength', 'excel', 'pdf',
        ]
    });
}

