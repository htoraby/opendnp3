// Copyright 2013-2019 Automatak, LLC
//
// Licensed to Green Energy Corp (www.greenenergycorp.com) and Automatak
// LLC (www.automatak.com) under one or more contributor license agreements. 
// See the NOTICE file distributed with this work for additional information
// regarding copyright ownership. Green Energy Corp and Automatak LLC license
// this file to you under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License. You may obtain
// a copy of the License at:
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Automatak.DNP3.Interface
{
  /// <summary>
  /// Defines the interoperable values of the Control Code
  /// Refer to pages 506-510 of 1815 for a full description
  /// </summary>
  public enum ControlCode : byte
  {
    /// <summary>
    /// Does not initiate an action or change an in-progress or pending command.
    /// </summary>
    NUL = 0x0,
    /// <summary>
    /// Cancel in-progress and pending commands. Take no additional action.
    /// </summary>
    NUL_CANCEL = 0x20,
    /// <summary>
    /// For activation model, set output to active for the duration of the On-time. For both complementary models, return NOT_SUPPORTED status.
    /// </summary>
    PULSE_ON = 0x1,
    /// <summary>
    /// Cancel in-progress and pending commands, process the remainder of the fields as if the control code were PULSE_ON
    /// </summary>
    PULSE_ON_CANCEL = 0x21,
    /// <summary>
    /// Non-interoperable code. Do not use for new applications. return NOT_SUPPORTED
    /// </summary>
    PULSE_OFF = 0x2,
    /// <summary>
    /// Non-interoperable code. Do not use for new applications. Cancel in-progress and pending commands, process remainder of fields as if the control code were PULSE_OFF
    /// </summary>
    PULSE_OFF_CANCEL = 0x22,
    /// <summary>
    /// For activation model, set output to active for the duration of the On-time. For complementary latch model, set the output to active. For complementary two-output model, set the close output to active for the duration of the On-time.
    /// </summary>
    LATCH_ON = 0x3,
    /// <summary>
    /// Cancel in-progress and pending commands, process the remainder of the fields as if the control code were LATCH_ON.
    /// </summary>
    LATCH_ON_CANCEL = 0x23,
    /// <summary>
    /// For activation model, set output to active for the duration of the On-time. For complementary latch model, set the output to inactive. For complementary two-output model, set the trip output to active for the duration of the On-time.
    /// </summary>
    LATCH_OFF = 0x4,
    /// <summary>
    /// Cancel in-progress and pending commands, process the remainder of the fields as if the control code were LATCH_OFF.
    /// </summary>
    LATCH_OFF_CANCEL = 0x24,
    /// <summary>
    /// For activation model, set output to active for the duration of the On-time. For complementary latch model, set the output to active. For complementary two-output model, set the close output to active for the duration of the On-time.
    /// </summary>
    CLOSE_PULSE_ON = 0x41,
    /// <summary>
    /// Cancel in-progress and pending commands, process the remainder of the fields as if the control code were CLOSE_PULSE_ON.
    /// </summary>
    CLOSE_PULSE_ON_CANCEL = 0x61,
    /// <summary>
    /// For activation model, set output to active for the duration of the On-time. For complementary latch model, set the output to inactive. For complementary two-output model, set the trip output to active for the duration of the On-time.
    /// </summary>
    TRIP_PULSE_ON = 0x81,
    /// <summary>
    /// Cancel in-progress and pending commands, process the remainder of the fields as if the control code were TRIP_PULSE_ON.
    /// </summary>
    TRIP_PULSE_ON_CANCEL = 0xA1,
    /// <summary>
    ///  undefined command (used by DNP standard)
    /// </summary>
    UNDEFINED = 0xFF
  }
}