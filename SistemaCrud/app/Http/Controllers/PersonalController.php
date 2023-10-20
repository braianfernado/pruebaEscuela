<?php

namespace App\Http\Controllers;

use App\Models\Personal;
use Illuminate\Http\Request;


class PersonalController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $datos['personal']=Personal::paginate(5);
        return view('personal.index', $datos);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('personal.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $datosPersonal = request()->except('_token');
        Personal::insert($datosPersonal);
       return redirect('personal')->with('mensaje','Agregado Correctamente');
        
    }

    /**
     * Display the specified resource.
     */
    public function show(Personal $personal)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit($id)
    {

        $personal=Personal::findOrFail($id);
        return view('personal.edit', compact('personal'));
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, $id)
    {
        
        $datosPersonal = request()->except(['_token','_method']);
        Personal::where('id','=',$id)->update($datosPersonal);

        $personal=Personal::findOrFail($id);
        return view('personal.edit', compact('personal'));

    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($id)
    {
        Personal::destroy($id);

        return redirect('personal')->with('mensaje','Registro Eliminado'); 
       
    }
}
