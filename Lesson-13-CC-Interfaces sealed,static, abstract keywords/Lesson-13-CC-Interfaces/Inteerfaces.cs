using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
	public interface IBreakable
	{
		void Break();
	}

	public interface IElectronicDevice : IBreakable
	{
		bool IsTurnOn { get; set; }
		void On();
		void Off();
	}

	public interface IHardOfFable
	{
		void HardOff();
	}
}
