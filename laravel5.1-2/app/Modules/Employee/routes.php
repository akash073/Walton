<?php
/**
 * Created by IntelliJ IDEA.
 * User: Mhamudul Hasan
 * Date: 05/05/2016
 * Time: 11:56 AM
 */
/*
 http://kamranahmed.info/blog/2015/12/03/creating-a-modular-application-in-laravel/
 * */
Route::group(['prefix' => 'employee', 'namespace' => 'App\Modules\Employee\Controllers'], function () {
   // Route::get('/', ['as' => 'Dummy.index', 'uses' => 'DummyController@index']);
    Route::get('/', 'DummyController@index');
 //   Route::get('model-test', ['as' => 'module-one.modelTest', 'uses' => 'IndexController@modelTest']);
});