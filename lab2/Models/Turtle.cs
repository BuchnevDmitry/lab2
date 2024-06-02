using System;
using System.Collections.Generic;

public class Turtle : Animal
{
    protected double _maxSpeed = 15.0;

    protected double _speed = 0;

    public override string Stay()
    {
        if (_speed == 0) return "Животное уже стоит";

        _speed -= _maxSpeed / 3;
        if (_speed < 0) _speed = 0;
        return $"Скорость черепахи = {_speed.ToString()}";
    }

    public override string Go()
    {
        if (_speed == _maxSpeed) return "Скорость уже максимальная";

        _speed += _maxSpeed / 3;
        if (_speed > _maxSpeed) _speed = _maxSpeed;
        return $"Скорость черепахи = {_speed.ToString()}";
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
        return "Черепаха не издает звуков";
    }

    public override string Up()
    {
        _speed = 0;
        return "Черепаха не может лазить по деревьям";
    }

    public override string Down()
    {
        return "Черепаха не может лазить по деревьям";
    }
}