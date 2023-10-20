

<form action="{{ url('/personal') }}"  method="post">

@csrf 

@include('personal.form',['modo'=>'Crear'])

</form>