using System;
using Xunit;
using HomeworkLib;

namespace HomeworkLib.Tests
{
    public class ClassRoomTests
    {
        [Fact]
        public void Pupils_AreFilled()
        {
            var cr = new ClassRoom(new ExcelentPupil(), new BadPupil());
            Assert.Equal(4, cr.Pupils.Length);
            Assert.IsType<ExcelentPupil>(cr.Pupils[0]);
            Assert.IsType<BadPupil>(cr.Pupils[1]);
            Assert.IsType<Pupil>(cr.Pupils[2]);
            Assert.IsType<Pupil>(cr.Pupils[3]);
        }
    }
}
