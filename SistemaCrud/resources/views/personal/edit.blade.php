 
<form action="{{ url('/personal/'.$personal->id) }}" method="post">

@csrf
{{method_field('PATCH')}}
@include('personal.form',['modo'=>'Editar'])

</form>
