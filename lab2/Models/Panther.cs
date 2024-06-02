using System;
using System.Collections.Generic;

public class Panther : Animal
{
	protected double _maxSpeed = 88.0;
	protected double _speed = 0;
	protected bool _onTree = false;

	public override string Stay()
	{
		if (_speed == 0) return "�������� ��� �����";

		_speed -= _maxSpeed / 3;
		if(_speed < 0) _speed = 0;
		return $"�������� ������� = {_speed.ToString()}";
    }

	public override string Go()
	{
		if (_onTree) return "�������� �� ������";
		if (_speed == _maxSpeed) return "�������� ��� ������������";

		_speed += _maxSpeed / 3;
		if (_speed > _maxSpeed) _speed = _maxSpeed;
		return $"�������� ������� = {_speed.ToString()}";
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
		return "�������";
	}

	public override string Up()
	{
		_speed = 0;
		_onTree = true;
		return "�������� ������� �� ������";
	}

	public override string Down()
	{
		_onTree = false;
		return "�������� ������ � ������";
	}
}