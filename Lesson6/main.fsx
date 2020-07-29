let mutable name = "issac"
name <- "kate"

module Mutable =
    let mutable petrol = 100.0

    let drive distance =
        if distance = "far" then petrol <- petrol / 2.0
        elif distance = "medium" then petrol <- petrol - 10.0
        else petrol <- petrol - 1.0

    drive "far"
    drive "medium"
    drive "short"

    assert (petrol = 39.0)

module Immutable =
    let drive distance petrol =
        if distance = "far" then petrol / 2.0
        elif distance = "medium" then petrol - 10.0
        else petrol - 1.0

    let petrol =
        100.0
        |> drive "far"
        |> drive "medium"
        |> drive "short"

    assert (petrol = 39.0)
