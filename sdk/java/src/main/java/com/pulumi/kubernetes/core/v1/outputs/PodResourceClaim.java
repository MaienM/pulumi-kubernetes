// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.core.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.exceptions.MissingRequiredPropertyException;
import com.pulumi.kubernetes.core.v1.outputs.ClaimSource;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class PodResourceClaim {
    /**
     * @return Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.
     * 
     */
    private String name;
    /**
     * @return Source describes where to find the ResourceClaim.
     * 
     */
    private @Nullable ClaimSource source;

    private PodResourceClaim() {}
    /**
     * @return Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.
     * 
     */
    public String name() {
        return this.name;
    }
    /**
     * @return Source describes where to find the ResourceClaim.
     * 
     */
    public Optional<ClaimSource> source() {
        return Optional.ofNullable(this.source);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(PodResourceClaim defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String name;
        private @Nullable ClaimSource source;
        public Builder() {}
        public Builder(PodResourceClaim defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.name = defaults.name;
    	      this.source = defaults.source;
        }

        @CustomType.Setter
        public Builder name(String name) {
            if (name == null) {
              throw new MissingRequiredPropertyException("PodResourceClaim", "name");
            }
            this.name = name;
            return this;
        }
        @CustomType.Setter
        public Builder source(@Nullable ClaimSource source) {

            this.source = source;
            return this;
        }
        public PodResourceClaim build() {
            final var _resultValue = new PodResourceClaim();
            _resultValue.name = name;
            _resultValue.source = source;
            return _resultValue;
        }
    }
}
