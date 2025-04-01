var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.13.6/i18n/ja.json"
        },
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "streetAddress", "width": "15%" },
            { "data": "city", "width": "15%" },
            { "data": "state", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/company/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> 修正</a>               
                     <a onClick=Delete('/admin/company/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> 削除</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: '本当に削除しますか？',
        text: "この操作は元に戻せません！",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'はい、削除します！',
        cancelButtonText: 'キャンセル'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}