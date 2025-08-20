$(document).ready(function () {
    $('#ReturnGoods').DataTable({
        dom: '<"d-flex justify-content-between align-items-center mb-2"Bf>rtip',
        layout: {
            topstart: {
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ],
            },
        },
       
        responsive: true,
        ajax: {
            url: "/GRN/getReturnGood",   
            type: "GET",
            dataType: "json"           
        },
        columns: [
            { data: "GoodsReturnId" },
            { data: "GoodsReturnCode" },
            { data: "FailedQCCode" },
            { data: "StatusId" },
            { data: "TransporterName" },
            { data: "TransportContactNo" },
            { data: "VehicleTypeId" },
            { data: "VehicleNo" },
            { data: "AddedDate" },
            { data: "AddedBy" },
            {
                data: null,
                orderable: false,
                searchable: false,
                defaultContent: '<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop"> Create Gr</button>'
            }
        ]
    });
});

