using System;
using System.Collections.Generic;
using System.Windows;

public class Dog : Animal
{
    protected double _maxSpeed = 30.0;

    protected double _speed = 0;

    public override string Stay()
    {
        if (_speed == 0) return "Животное уже стоит";

        _speed -= _maxSpeed / 3;
        if (_speed < 0) _speed = 0;
        return $"Скорость собаки = {_speed.ToString()}";
    }

    public override string Go()
    {
        if (_speed == _maxSpeed) return "Скорость уже максимальная";

        _speed += _maxSpeed / 3;
        if (_speed > _maxSpeed) _speed = _maxSpeed;
        return $"Скорость собаки = {_speed.ToString()}";
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetMaxSpeed()
    {
        return _maxSpeed;
    }

    public override string GetVoice()
    {
        return "Гав";
    }

    public override string Up()
    {
        _speed = 0;
        return "Собака не может лазить по деревьям";
    }

    public override string Down()
    {
        return "Собака не может лазить по деревьям";
    }
}