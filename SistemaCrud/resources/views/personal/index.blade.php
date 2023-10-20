<link rel="stylesheet" href="resources/css/estilos.css">
<h1>SistemaCrud</h1>

@if(Session::has('mensaje'))
{{Session::get('mensaje') }}

@endif

<a href="{{ url('/personal/create') }}" class="btn btn-success" >Nuevo registro</a>
<table class="table table-light">
    <thead class="thead-light">
        <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Correo</th>
            <th>telefono</th>
            <th>Aciones</th>
        </tr>
    </thead>
    <tbody>
        @foreach($personal as $personals)
        <tr>
            <td>{{$personals->id}}</td>
            <td>{{$personals->Nombre}}</td>
            <td>{{$personals->Apellidos}}</td>
            <td>{{$personals->Correo}}</td>
            <td>{{$personals->Telefono}}</td>
            <th>
                
            <a href="{{url('/personal/'.$personals->id.'/edit')}}">
                
            Editar
        
        </a>
             | 
                
            <form action="{{ url('/personal/'.$personals->id) }}" method="post">
                @csrf
                {{method_field('DELETE') }}

                <input type="submit" onclick="return confirm('¿Quiere borrar?')" value="Borrar">
            </form>
            </th>
     
        </tr>
        @endforeach
    </tbody>
</table>