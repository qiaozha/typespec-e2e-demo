// Licensed under the MIT License.

import { PetStoreContext } from "../../api/petStoreContext.js";
import { update, get } from "../../api/petInsurance/index.js";
import { Insurance } from "../../models/models.js";
import { InsuranceUpdate } from "../../models/typeSpec/rest/resource/models.js";
import {
  PetInsuranceUpdateOptionalParams,
  PetInsuranceGetOptionalParams,
} from "../../api/options.js";

/** Interface representing a PetInsurance operations. */
export interface PetInsuranceOperations {
  /** Updates the singleton resource. */
  update: (
    petId: number,
    properties: InsuranceUpdate,
    options?: PetInsuranceUpdateOptionalParams,
  ) => Promise<Insurance>;
  /** Gets the singleton resource. */
  get: (
    petId: number,
    options?: PetInsuranceGetOptionalParams,
  ) => Promise<Insurance>;
}

function _getPetInsurance(context: PetStoreContext) {
  return {
    update: (
      petId: number,
      properties: InsuranceUpdate,
      options?: PetInsuranceUpdateOptionalParams,
    ) => update(context, petId, properties, options),
    get: (petId: number, options?: PetInsuranceGetOptionalParams) =>
      get(context, petId, options),
  };
}

export function _getPetInsuranceOperations(
  context: PetStoreContext,
): PetInsuranceOperations {
  return {
    ..._getPetInsurance(context),
  };
}
